using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal class SelectionChanger<T> : ObservableCollection<T>
	{
		private Func<T, bool> canSelectItem;
		private Func<T, bool> canUnselectItem;
		private Func<System.Windows.Controls.SelectionChangedEventArgs, bool> canChangeSelection;
		private Func<T, T> coerceItem;
		private List<T> addToSelection;
		private WeakReferenceList<T> removeFromSelection;
		private List<T> internalSelection;
		private bool isActive;

		public SelectionChanger(Func<T, bool> isItemValidForSelection,
								Func<T, bool> isItemValidForUnselection,
								Func<System.Windows.Controls.SelectionChangedEventArgs, bool> isSelectionChangePossible)
			: this(isItemValidForSelection)
		{
			canChangeSelection = isSelectionChangePossible;
			canUnselectItem = isItemValidForUnselection;
		}

		public SelectionChanger(Func<T, bool> isItemValidForSelection)
			: this()
		{
			this.canSelectItem = isItemValidForSelection;
		}

		public SelectionChanger()
		{
			this.addToSelection = new List<T>(1);
			this.removeFromSelection = new WeakReferenceList<T>();
			this.internalSelection = new List<T>(1);
			this.InitFlags();
		}

		public event System.Windows.Controls.SelectionChangedEventHandler SelectionChanged;

		/// <summary>
		/// Coerce Item before it is selected.
		/// </summary>
		internal Func<T, T> CoerceItemCallback
		{
			get
			{
				return this.coerceItem;
			}
			set
			{
				this.coerceItem = value;
			}
		}

		/// <summary>
		/// True if there is a SelectionChange currently in progress.
		/// </summary>
		private bool IsActive
		{
			get
			{
				return this.isActive;
			}
		}

		/// <summary>
		/// Commit selection changes.
		/// </summary>
		internal void End()
		{
			// Debug.Assert(_owner.CheckAccess());
			Debug.Assert(this.isActive, "There must be a selection change active when you call SelectionChange.End()");

			var isRealSelectionChangePending = this.removeFromSelection.Count > 0 || this.addToSelection.Count > 0;
			var e = this.BuildSelectionChangedEventArgs();

			if (isRealSelectionChangePending &&  canChangeSelection != null)
			{
				if (canChangeSelection(e))
				{
					this.Cancel();
					return;
				}
			}

			this.InitFlags();

			this.SynchronizeInternalSelection();

			if (isRealSelectionChangePending)
			{
				this.InvokeSelectionChangedEvent(e);
			}
		}

		internal System.Windows.Controls.SelectionChangedEventArgs BuildSelectionChangedEventArgs()
		{

             return new SelectionChangedEventArgs(
                    System.Windows.Controls.Primitives.Selector.SelectionChangedEvent, this.removeFromSelection.ToList(), this.addToSelection);

		}

		internal void AddJustThis(T item)
		{
			this.Begin();
			int count = this.Items.Count;
			for (int i = 0; i < count; i++)
			{
				T itemInCollection = this.Items[i];
				if (itemInCollection.Equals(item))
				{
					continue;
				}
				else
				{
					Remove(itemInCollection);
				}
			}

			if (!this.Items.Contains(item))
			{
				Add(item);
			}
			this.End();
		}

		/// <summary>
		/// Begin tracking selection changes.
		/// </summary>
		internal void Begin()
		{
			// Debug.Assert(_owner.CheckAccess());
			Debug.Assert(!this.isActive, "Cannot begin a new SelectionChange when another one is active.");

			this.isActive = true;
			this.addToSelection.Clear();
			this.removeFromSelection.Clear();
		}

		/// <summary>
		/// Cancels the currently active SelectionChanger.
		/// </summary>
		internal void Cancel()
		{
			// Debug.Assert(_owner.CheckAccess());
			this.InitFlags();
			if (this.addToSelection.Count > 0)
			{
				this.addToSelection.Clear();
			}
			if (this.removeFromSelection.Count > 0)
			{
				this.removeFromSelection.Clear();
			}
		}

		protected override void ClearItems()
		{
			base.ClearItems();

			this.addToSelection.Clear();
			this.removeFromSelection = new WeakReferenceList<T>();
			if (this.internalSelection != null)
			{
				foreach (var item in this.internalSelection)
				{
					removeFromSelection.Add(item);
				}
			}
			this.internalSelection.Clear();

			if (!this.isActive)
			{
				this.InvokeSelectionChangedEvent();
			}
		}

		protected override void InsertItem(int index, T item)
		{
			if (this.isActive)
			{
				this.Select(item);
			}
			else
			{
				this.Begin();
				this.Select(item);
				this.End();
			}
		}

		protected override void RemoveItem(int index)
		{
			T changedItem = base[index];
			if (this.isActive)
			{
				this.Unselect(changedItem);
			}
			else
			{
				this.Begin();
				this.Unselect(changedItem);
				this.End();
			}
		}

		protected override void SetItem(int index, T item)
		{
			// Clear old select/unselect collections
			this.Begin();
			T oldItem = base[index];

			// Add oldItem to unselected collection
			this.removeFromSelection.Add(oldItem);

			// Add oldItem to unselected collection
			this.addToSelection.Add(item);

			// Replace the old item
			// and fires CollectionChanged event with
			// action Replace
			base.SetItem(index, item);

			// Invoke SelectionChanged event
			this.InvokeSelectionChangedEvent();

			// Cancel the operation because the change is already done
			// CollectionChanged and SelectionChanged events are fired
			// with the correct event args.
			// If we call End() method we will trigger CollectionChanged event
			// with action Added after CollectionChanged event with Action Replace.
			this.Cancel();
		}

		/// <summary>
		/// Queue something to be added to the selection.
		/// Does nothing if the item is already selected.
		/// </summary>
		private void Select(T item)
		{
			// Debug.Assert(_owner.CheckAccess());
			Debug.Assert(this.isActive, "No SelectionChange is active.");

			// To support Unselect(item) / Select(item) where item is already selected.
			if (this.removeFromSelection.Remove(item))
			{
				return;
			}

			// if item is already in select queue, ignore this operation
			if (this.addToSelection.Contains(item))
			{
				return;
			}

			if (!this.internalSelection.Contains(item))
			{
				this.AddToSelection(item);
			}
		}

		/// <summary>
		/// Queue something to be removed from the selection.
		/// Does nothing if the item is not already selected.
		/// </summary>
		private void Unselect(T item)
		{
			// Debug.Assert(_owner.CheckAccess());
			Debug.Assert(this.isActive, "No SelectionChange is active.");

			// To support Select(item) / Unselect(item) where item is not already selected.
			if (this.addToSelection.Remove(item))
			{
				return;
			}

			// if item is already in unselect queue, ignore this operation
			if (this.removeFromSelection.Contains(item))
			{
				return;
			}

			if (this.internalSelection.Contains(item))
			{
				this.RemoveFromSelection(item);
			}
		}

		/// <summary>
		/// Select just this item; all other items in Selection will be removed.
		/// </summary>
		private void SelectJustThisItem(T item)
		{
			this.Begin();
			if (this.Items.Count > 0)
			{
				this.Clear();
			}

			try
			{
				if (item != null)
				{
					if (this.removeFromSelection.Contains(item))
					{
						this.removeFromSelection.Remove(item);
					}
					else
					{
						this.Select(item);
					}
				}
			}
			finally
			{
				this.End();
			}
		}

		private void AddToSelection(T item)
		{
			bool result = true;
			T coercedItem = default(T);
			if (this.CoerceItemCallback != null)
			{
				coercedItem = this.CoerceItemCallback(item);
			}

			if (this.canSelectItem != null)
			{
				result = this.canSelectItem(this.CoerceItemCallback != null ? coercedItem : item);
			}
			if (result)
			{
				T newItem = this.CoerceItemCallback != null ? coercedItem : item;
				if (newItem != null)
				{
					this.addToSelection.Add(newItem);
				}
			}
		}

		private void RemoveFromSelection(T item)
		{
			bool result = true;
			if (this.canUnselectItem != null)
			{
				result = this.canUnselectItem(item);
			}
			if (result && item != null)
			{
				this.removeFromSelection.Add(item);
			}
		}

		private void InvokeSelectionChangedEvent()
		{
			this.InvokeSelectionChangedEvent(this.BuildSelectionChangedEventArgs());
		}

		private void InvokeSelectionChangedEvent(System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (this.SelectionChanged != null)
			{
				this.SelectionChanged(this, e);
			}
		}

		/// <summary>
		/// Update the InternalSelection.
		/// </summary>
		private void SynchronizeInternalSelection()
		{
			foreach (T item in this.removeFromSelection)
			{
				int index = IndexOf(item);
				if (index > -1)
				{
					base.RemoveItem(index);
				}
				this.internalSelection.Remove(item);
			}

			foreach (T item in this.addToSelection)
			{
				base.InsertItem(this.Items.Count, item);

				Debug.Assert(!this.internalSelection.Contains(item), "InternalSelection should not containt newly selected items!!");
				this.internalSelection.Add(item);
			}
		}

		private void InitFlags()
		{
			this.isActive = false;
		}
	}
}