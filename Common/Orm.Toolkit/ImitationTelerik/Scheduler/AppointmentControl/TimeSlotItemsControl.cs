using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Orm.Toolkit.Telerik.Windows.Controls.DragDrop;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Contains and represents a collection of <see cref="TimeSlot"/>.
	/// </summary>
	public class TimeSlotItemsControl : ListBox
	{
		/// <summary>
		/// Identifies the <see cref="SelectedTimeSlot"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="SelectedTimeSlot"/> property.</returns>
		internal static readonly DependencyProperty SelectedTimeSlotProperty =
			DependencyProperty.Register(
				"SelectedTimeSlot",
				typeof(TimeSlot),
				typeof(TimeSlotItemsControl),
				new PropertyMetadata(null, OnSelectedTimeSlotChanged));

		/// <summary>
		/// Identifies the <see cref="SelectedTimeSlot"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="SelectedTimeSlot"/> property.</returns>
		internal static readonly DependencyProperty TimeSlotsSourceProperty =
			DependencyProperty.Register(
				"TimeSlotsSource",
				typeof(IEnumerable),
				typeof(TimeSlotItemsControl),
				new PropertyMetadata(null, OnItemsSourceChanged));

		private bool shouldUpdateSelectedTimeSlot = true;

		static TimeSlotItemsControl()
		{
			// TODO: Move to the control Style
			SelectionModeProperty.OverrideMetadata(
				typeof(TimeSlotItemsControl), new FrameworkPropertyMetadata(SelectionMode.Extended));
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="TimeSlotItemsControl"/> class.
		/// </summary>
		public TimeSlotItemsControl()
		{		
			RadDragAndDropManager.AddDropInfoHandler(this, this.OnTimeSlotItemsControlDropInfo);
			RadDragAndDropManager.AddDropQueryHandler(this, this.OnTimeSlotItemsControlDropQuery);

		}

		/// <summary>
		/// Gets or sets the selected <see cref="TimeSlot"/>. If there are more than one selected time slot, a single time slot is returned
		/// that starts from the first selected time slot and end at the end of the last selected time slot. This is a dependency property.
		/// </summary>
		/// <returns>Currently selected <see cref="TimeSlot"/> if any, otherwise null. The default value is null</returns>
		internal TimeSlot SelectedTimeSlot
		{
			get
			{
				return (TimeSlot)this.GetValue(SelectedTimeSlotProperty);
			}
			set
			{
				this.SetValue(SelectedTimeSlotProperty, value);
			}
		}

		internal IEnumerable TimeSlotsSource
		{
			get
			{
				return (IEnumerable)this.GetValue(TimeSlotsSourceProperty);
			}
			set
			{
				this.SetValue(TimeSlotsSourceProperty, value);
			}
		}

		/// <summary>
		/// Gets the items.
		/// </summary>
		/// <returns>The items.</returns>
		internal IEnumerable<TimeSlotItem> TimeSlotItems
		{
			get
			{
				foreach (object item in this.Items)
				{
					yield return this.ItemContainerGenerator.ContainerFromItem(item) as TimeSlotItem;
				}
			}
		}

		internal RadScheduler Scheduler
		{
			get
			{
				return this.ParentOfType<RadScheduler>();
			}
		}

		internal AppointmentsControl AppointmentsControl
		{
			get
			{
				return this.GetParent<AppointmentsControl>();
			}
		}

		/// <summary>
		/// When overridden in a derived class, is invoked whenever application
		/// code or internal processes (such as a rebuilding layout pass) call
		/// <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			if (this.Scheduler != null)
			{
				if (this.Scheduler.TimeSlotTemplateSelector != null)
				{
					this.ItemTemplateSelector = this.Scheduler.TimeSlotTemplateSelector;
				}

			}
		}

		internal static void ChangeAllDraggedItemsOpacity(AppointmentItem item)
		{
			var draggedAppointmentItems = from draggedApp in item.ParentItemsControl.AppointmentItems
										  where draggedApp != null
										  select draggedApp;

			foreach (var draggedApp in draggedAppointmentItems)
			{
				draggedApp.Opacity = 1;
			}
		}

		internal void ClearAllItemsIsDropPossibleProperty()
		{
			foreach (var item in this.TimeSlotItems)
			{
				item.IsDropPossible = false;
			}
		}

		internal void SetSelectedResource()
		{
			var scheduler = this.Scheduler;
			if (scheduler != null && !String.IsNullOrEmpty(scheduler.GroupBy) && this.AppointmentsControl != null)
			{
				var group = this.AppointmentsControl.DataContext as ResourceGroup;
				scheduler.SelectedResource = group.Resource;
			}
		}

		internal TimeSlot GetDestinationTimeSlot(IAppointment app, TimeSlot slot)
		{
			DateTime st = app.Start;
			DateTime end = app.End;
			if (app.IsAllDay() || slot.End == slot.Start.AddDays(1))
			{
				var duration = app.End - app.Start;

				if (app.IsAllDay() && slot.End == slot.Start.AddDays(1))
				{
					st = slot.Start;
					end = st + duration;
				}
				else
				{
					st = slot.Start;
					end = slot.End;
				}
			}
			else
			{
				TimeSpan offset = slot.Start - app.Start - this.Scheduler.DroppedAppointmentDuration;

				if (offset.IsNegative())
				{
					st = app.Start + offset;
					end = app.End + offset;
				}
				else
				{
					end = app.End + offset;
					st = app.Start + offset;
				}
			}
			return new TimeSlot(st, end);
		}

		/// <summary>
		/// Provides derived classes an opportunity to handle changes to the <see cref="SelectedTimeSlot"/> property.
		/// </summary>
		/// <param name="args">The <see cref="System.Windows.DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>
		protected virtual void OnSelectedTimeSlotChanged(DependencyPropertyChangedEventArgs args)
		{
			this.SetSelectedTimeSlot();
		}

		/// <summary>
		/// Creates or identifies the element used to display a specified item.
		/// </summary>
		/// <returns>
		/// A <see cref="ListBoxItem"/>.
		/// </returns>
		protected override DependencyObject GetContainerForItemOverride()
		{
			return new TimeSlotItem();
		}

		/// <summary>
		/// Raises the <see cref="FrameworkElement.Initialized"/> event and sets <see cref="FrameworkElement.DefaultStyleKey" /> from the active theme.
		/// </summary>
		/// <param name="e">The <see cref="RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			this.DefaultStyleKey = this.GetDefaultStyleKey();
		}

		/// <summary>
		/// Called when the source of an item in a selector changes.
		/// </summary>
		/// <param name="oldValue">Old value of the source.</param>
		/// <param name="newValue">New value of the source.</param>
		protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
		{
			base.OnItemsSourceChanged(oldValue, newValue);
			this.UpdateTimeSlots(oldValue, newValue);
		}


		/// <summary>
		/// Responds to a list box selection change by raising a <see cref="System.Windows.Controls.Primitives.Selector.SelectionChanged"/> event.
		/// </summary>
		/// <param name="e">Provides data for <see cref="System.Windows.Controls.SelectionChangedEventArgs"/>.</param>
		protected override void OnSelectionChanged(System.Windows.Controls.SelectionChangedEventArgs e)
		{
			base.OnSelectionChanged(e);

			if (this.shouldUpdateSelectedTimeSlot && this.SelectedItems.Count > 0)
			{
				var selectedItems = new TimeSlotGroup(this.SelectedItems.Cast<TimeSlot>());
				if (selectedItems != this.SelectedTimeSlot)
				{
					this.SelectedTimeSlot = selectedItems;
				}
			}

		}

		/// <summary>
		/// Prepares the specified element to display the specified item.
		/// </summary>
		/// <param name="element">Element used to display the specified item.</param>
		/// <param name="item">Specified item.</param>
		protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);

			var timeSlotItem = element as TimeSlotItem;
			if (timeSlotItem == null)
			{
				return;
			}

			timeSlotItem.TimeSlot = item as TimeSlot;

		}

		private static void ApplyTimeOffsetToDraggedAppointment(TimeSpan offset, IAppointment draggedAppointment)
		{
			// If the offset is negative we should first update the start date, avoinding situations where end date will come 
			// before the start date
			if (offset.IsNegative())
			{
				draggedAppointment.Start = draggedAppointment.Start + offset;
				draggedAppointment.End = draggedAppointment.End + offset;
			}
			else
			{
				draggedAppointment.End = draggedAppointment.End + offset;
				draggedAppointment.Start = draggedAppointment.Start + offset;
			}
		}

		/// <summary>
		/// Handles changes to the <see cref="SelectedTimeSlot"/> property.
		/// </summary>
		private static void OnSelectedTimeSlotChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((TimeSlotItemsControl)d).OnSelectedTimeSlotChanged(e);
		}
		private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((TimeSlotItemsControl)d).UpdateTimeSlots(e.OldValue as IEnumerable, e.NewValue as IEnumerable);
		}


		private void OnTimeSlotItemsControlDropInfo(object sender, DragDropEventArgs e)
		{
			if (this.Scheduler != null)
			{
				this.Scheduler.CurrentTimeSlotItemsControl = this;
			}
			var item = e.Options.Source as AppointmentItem;
			TimeSlotItem timeslotItem = e.Options.Destination as TimeSlotItem;
			var slot = timeslotItem.TimeSlot;
			IAppointment app = null;
			if (item != null)
			{
				 app = item.AppointmentSlot.Occurrence.Appointment;
			}
			if (e.Options.Status == DragStatus.DropComplete && item != null)
			{
				ChangeAllDraggedItemsOpacity(item);

				if (Keyboard.Modifiers == ModifierKeys.Control)
				{
					app = app.Copy();
					this.Scheduler.Appointments.Add(app);
				}
				this.ChangeAppointmentTime(app, slot);
				this.ChangeResourceGroup(app);
				this.CompleteDrop(app);
			}

			if (e.Options.Status == DragStatus.DropPossible && item != null)
			{
				this.HighlightDropArea(app, slot);
			}

			ContentControl control = e.Options.DragCue as ContentControl;
			if (control != null)
			{
				var tooltip = control.Content as DragVisualCue;
				if (tooltip != null)
				{
					tooltip.IsDraggingPossible = e.Options.Status != DragStatus.DropImpossible;
				}
			}
		}

		private void CompleteDrop(IAppointment app)
		{
			this.ClearAllItemsIsDropPossibleProperty();
			if (this.Scheduler != null)
			{
				this.Scheduler.CurrentTimeSlotItemsControl = null;
			}
			this.AppointmentsControl.AppointmentItemsControl.IsDragging = false;

			var editedEventArgs = new AppointmentEditedEventArgs(
			RadScheduler.AppointmentEditedEvent,
			app);
			this.RaiseEvent(editedEventArgs);
		}

		private void ChangeResourceGroup(IAppointment app)
		{
			if (this.Scheduler != null && !String.IsNullOrEmpty(this.Scheduler.GroupBy))
			{
				var selectedResource = (this.AppointmentsControl.DataContext as ResourceGroup).Resource;

				if (!app.Resources.Contains(selectedResource) && selectedResource != null)
				{
					app.Resources.Remove(app.Resources.GetResourceByType(selectedResource.ResourceType));
					app.Resources.Add(selectedResource);
				}
				else if (selectedResource == null)
				{
					var resourcestoRemove = app.Resources.GetResourcesByType(this.Scheduler.GroupBy);
					foreach (var res in resourcestoRemove)
					{
						app.Resources.Remove(res);
					}
				}
			}
		}

		private void HighlightTimeSlotItems(DateTime st, DateTime end)
		{
			foreach (var sl in this.TimeSlotItems)
			{
				if (sl.TimeSlot.IntersectsWith(new TimeSlot(st, end)))
				{
					sl.IsDropPossible = true;
				}
				else
				{
					sl.IsDropPossible = false;
				}
			}
		}

		private void HighlightDropArea(IAppointment app, TimeSlot slot)
		{
			TimeSlot appSlot = this.GetDestinationTimeSlot(app, slot);
			this.HighlightTimeSlotItems(appSlot.Start, appSlot.End);
		}

        private void ChangeAppointmentTime(IAppointment app, TimeSlot slot)
        {
            if (this.Scheduler.ViewMode == SchedulerViewMode.Timeline || this.Scheduler.ViewMode == SchedulerViewMode.Month)
            {
                var dayDuration = slot.Start.Date - app.Start.Date;

                if (dayDuration != TimeSpan.Zero)
                {
                    app.Start = app.Start.Add(dayDuration);
                    app.End = app.End.Add(dayDuration);
                }
                else
                {
                    var startTimeOffset = slot.Start.TimeOfDay - app.Start.TimeOfDay;
                    var appDuration = app.Duration();
                    app.Start = app.Start.Add(startTimeOffset);
                    app.End = app.Start.Add(appDuration);
                }
            }
            else if (app.IsAllDay() || slot.End == slot.Start.AddDays(1))
            {
                var duration = app.End - app.Start;

                if (app.IsAllDay() && slot.End == slot.Start.AddDays(1))
                {
                    app.Start = slot.Start;
                    app.End = app.Start + duration;
                }
                else
                {
                    app.Start = slot.Start;
                    app.End = slot.End;
                    app.IsAllDayEvent = false;
                }
            }
            else
            {
                TimeSpan offset = slot.Start - app.Start - this.Scheduler.DroppedAppointmentDuration;

                ApplyTimeOffsetToDraggedAppointment(offset, app);
            }
        }

		private void OnTimeSlotItemsControlDropQuery(object sender, DragDropQueryEventArgs e)
		{
			if (e.Options.DragCue != null)
			{
				e.QueryResult = true;
			}
		}

		private void OnTimeSlotsUpdated(object sender, EventArgs e)
		{
			this.SetSelectedTimeSlot();
		}

		private void SetSelectedTimeSlot()
		{
			if (this.SelectedTimeSlot == null)
			{
				return;
			}

			IEnumerable<TimeSlot> itemsToSelect = from TimeSlot slot in this.Items
												  where this.SelectedTimeSlot.IntersectsWith(slot)
												  select slot;
			try
			{
				this.shouldUpdateSelectedTimeSlot = false;
				this.SelectItems(itemsToSelect);
			}
			finally
			{
				this.shouldUpdateSelectedTimeSlot = true;
			}
		}

		/// <summary>
		/// Called when the source of an item in a selector changes.
		/// </summary>
		/// <param name="oldValue">Old value of the source.</param>
		/// <param name="newValue">New value of the source.</param>
		private void UpdateTimeSlots(IEnumerable oldValue, IEnumerable newValue)
		{
			this.SetSelectedTimeSlot();

			if (oldValue != null)
			{
				var oldTimeSlots = (TimeSlotCollectionView)oldValue;
				oldTimeSlots.TimeSlotsUpdated -= this.OnTimeSlotsUpdated;
			}

			if (newValue != null)
			{
				var newTimeSlots = (TimeSlotCollectionView)newValue;
				newTimeSlots.TimeSlotsUpdated += this.OnTimeSlotsUpdated;
			}
		}
	}
}
