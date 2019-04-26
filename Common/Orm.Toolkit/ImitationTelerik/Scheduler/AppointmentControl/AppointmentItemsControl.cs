using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using Orm.Toolkit.Telerik.Windows.Controls.DragDrop;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Contains appointments split into <see cref="AppointmentSlot"/>.
	/// </summary>
	public class AppointmentItemsControl : ListBox
	{
		/// <summary>
		/// Identifies the <see cref="IsDragging"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="IsDragging"/> property.</returns>
		public static readonly DependencyProperty IsDraggingProperty =
			DependencyProperty.Register(
				"IsDragging",
				typeof(bool),
				typeof(AppointmentItemsControl),
				new PropertyMetadata(BooleanBoxes.FalseBox));

		/// <summary>
		/// Identifies the <see cref="IsResizing"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="IsResizing"/> property.</returns>
		public static readonly DependencyProperty IsResizingProperty =
			DependencyProperty.Register(
				"IsResizing",
				typeof(bool),
				typeof(AppointmentItemsControl),
				new PropertyMetadata(BooleanBoxes.FalseBox));

		/// <summary>
		/// Identifies the <see cref="SelectedAppointments"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="SelectedAppointments"/> property.</returns>
		internal static readonly DependencyProperty SelectedAppointmentsProperty =
			DependencyProperty.Register(
				"SelectedAppointments",
				typeof(IList<IAppointment>),
				typeof(AppointmentItemsControl),
				new PropertyMetadata(null, new PropertyChangedCallback(OnSelectedAppointmentsChanged)));

		private int entranceCounter;

        private IEnumerable<IAppointment> previoslySelectedItems;

		private bool shouldUpdateSelectedAppointments = true;

     
        static AppointmentItemsControl()
        {
            // TODO: Move to the control Style
            var defaultPanelTemplate =
                new ItemsPanelTemplate(new FrameworkElementFactory(typeof(AppointmentPanel)));

            defaultPanelTemplate.Seal();

            ItemsPanelProperty.OverrideMetadata(
                typeof(AppointmentItemsControl), new FrameworkPropertyMetadata(defaultPanelTemplate));

            SelectionModeProperty.OverrideMetadata(
                typeof(AppointmentItemsControl), new FrameworkPropertyMetadata(SelectionMode.Extended));
        }


		/// <summary>
		/// Initializes a new instance of the <see cref="AppointmentItemsControl"/> class.
		/// </summary>
		public AppointmentItemsControl()
		{


			this.ResizeManager = new AppointmentResizeManager(this);

			this.SelectedAppointments = new SelectedAppointmentCollection();

			RadDragAndDropManager.AddDragQueryHandler(this, this.OnAppointmentItemsControlDragQuery);
		}

		/// <summary>
		/// Gets or sets a value indicating whether some appointment is currently being dragged. This is a dependency property.
		/// </summary>
		/// <returns>
		/// <c>True</c> if some appointment is currently being dragged; otherwise, <c>false</c>. The default values is <c>false</c>.
		/// </returns>
		public bool IsDragging
		{
			get
			{
				return (bool)this.GetValue(IsDraggingProperty);
			}
			set
			{
				this.SetValue(IsDraggingProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether some appointment is currently being resized. This is a dependency property.
		/// </summary>
		/// <returns>
		/// <c>True</c> if some appointment is currently being resized; otherwise, <c>false</c>. The default values is <c>false</c>.
		/// </returns>
		public bool IsResizing
		{
			get
			{
				return (bool)this.GetValue(IsResizingProperty);
			}
			set
			{
				this.SetValue(IsResizingProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets .... This is a dependency property.
		/// </summary>
		/// <returns>The default value is false</returns> 
		public IList<IAppointment> SelectedAppointments
		{
			get
			{
				return (IList<IAppointment>)this.GetValue(SelectedAppointmentsProperty);
			}
			internal set
			{
				this.SetValue(SelectedAppointmentsProperty, value);
			}
		}

		internal IEnumerable<AppointmentItem> AppointmentItems
		{
			get
			{
				foreach (AppointmentSlot slot in this.Items)
				{
					yield return this.GetAppointmentContainer(slot);
				}
			}
		}
		internal TimeSlotItemsControl TimeSlotItemsControl
		{
			get;
			set;
		}
		internal RadScheduler Scheduler
		{
			get
			{
				return this.ParentOfType<RadScheduler>();
			}
		}
		internal AppointmentResizeManager ResizeManager { get; set; }


		private Panel ItemsHost
		{
			get;
			set;
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
				if (this.Scheduler.AppointmentTemplateSelector == null)
				{
					var group = this.DataContext as ResourceGroup;
					if (group != null && group.ResourceStyleMapping != null && group.ResourceStyleMapping.AppointmentTemplate != null)
					{
						this.ItemTemplate = group.ResourceStyleMapping.AppointmentTemplate;
					}
					else
					{
						this.ItemTemplate = this.Scheduler.AppointmentTemplate;
					}
				}
				else
				{
					this.ItemTemplateSelector = this.Scheduler.AppointmentTemplateSelector;
				}
			}
		}

		internal AppointmentItem GetAppointmentContainer(AppointmentSlot slot)
		{
			return this.ItemContainerGenerator.ContainerFromItem(slot) as AppointmentItem;
		}

		internal void RecycleAllAppointmentItems()
		{
			VirtualizedAppointmentPanel panel = this.ItemsHost as VirtualizedAppointmentPanel;
			if (panel != null)
			{
				panel.RecycleAllAppointmentItems();
				panel.InvalidateMeasure();
			}
			if (this.ItemsHost != null)
			{
				foreach (UIElement item in this.ItemsHost.Children)
				{
					AppointmentItem container = item as AppointmentItem;
					if (container != null)
					{
						container.ClearValue(AppointmentItem.SchedulerProperty);
					}
				}
			}
		}

		/// <summary>
		/// Provides derived classes an opportunity to handle changes to the <see cref="SelectedAppointments"/> property.
		/// </summary>
		protected virtual void OnSelectedAppointmentsChanged(DependencyPropertyChangedEventArgs args)
		{
			var oldValue = args.OldValue as INotifyCollectionChanged;
			if (oldValue != null)
			{
				oldValue.CollectionChanged -= this.OnSelectedAppointmentsCollectionChanged;
			}

			var newValue = args.NewValue as SelectedAppointmentCollection;
			if (newValue != null)
			{
				newValue.CollectionChanged += this.OnSelectedAppointmentsCollectionChanged;
			}

			this.SetSelection();
		}

		/// <summary>
		/// Creates or identifies the element used to display a specified item.
		/// </summary>
		/// <returns>
		/// A <see cref="ListBoxItem"/>.
		/// </returns>
		protected override DependencyObject GetContainerForItemOverride()
		{
			return new AppointmentItem();
		}

		/// <summary>
		/// Determines if the specified item is (or is eligible to be) its own ItemContainer.
		/// </summary>
		/// <param name="item">Specified item.</param>
		/// <returns>
		/// True if the item is its own ItemContainer; otherwise, false.
		/// </returns>
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is AppointmentItem;
		}

		/// <summary>
		/// Prepares the specified element to display the specified item.
		/// </summary>
		/// <param name="element">Element used to display the specified item.</param>
		/// <param name="item">Specified item.</param>
		protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
		{

			if (this.ItemsHost == null)
			{
				this.ItemsHost = System.Windows.Media.VisualTreeHelper.GetParent(element) as Panel;
			}

			base.PrepareContainerForItemOverride(element, item);
			AppointmentItem appItem = element as AppointmentItem;
			if (appItem != null)
			{
				appItem.Scheduler = this.Scheduler;
				appItem.Content = item;
				appItem.UpdateProperties();
			}
		}

		/// <summary>
		/// Clears AppointmentItem brush properties.
		/// </summary>
		/// <param name="element">The appointmentItem.</param>
		/// <param name="item">The appointment slot.</param>
		protected override void ClearContainerForItemOverride(DependencyObject element, object item)
		{
			base.ClearContainerForItemOverride(element, item);
			AppointmentItem appItem = element as AppointmentItem;
			if (appItem != null)
			{
				appItem.ClearValue(AppointmentItem.SchedulerProperty);
				appItem.ClearValue(AppointmentItem.SelectedBackgroundProperty);
				appItem.ClearValue(AppointmentItem.MouseOverBackgroundProperty);
				appItem.ClearValue(AppointmentItem.BackgroundProperty);
				appItem.ClearValue(AppointmentItem.IsSelectedProperty);
			}
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
		/// Responds to the <see cref="UIElement.KeyDown"/> event.
		/// </summary>
		/// <param name="e">Provides data for <see cref="KeyEventArgs"/>.</param>
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);

			if (e.Key == Key.Delete)
			{
				if (this.SelectedIndex >= 0)
				{
					var selectedItem = (AppointmentSlot)this.SelectedValue;
					RadSchedulerCommands.DeleteAppointment.Execute(selectedItem.Occurrence, this);
				}
			}
			else if (e.Key == Key.Enter)
			{
				if (this.SelectedIndex >= 0)
				{
					var selectedItem = (AppointmentSlot)this.SelectedValue;
					RadSchedulerCommands.EditAppointment.Execute(selectedItem.Occurrence, this);
				}
			}
		}

		/// <summary>
		/// Responds to a list box selection change by raising a <see cref="Selector.SelectionChanged"/> event.
		/// </summary>
		/// <param name="e">Provides data for <see cref="SelectionChangedEventArgs"/>.</param>
		protected override void OnSelectionChanged(System.Windows.Controls.SelectionChangedEventArgs e)
		{
			// Only apply when there are only one item selected
			if (this.SelectedItems.Count == 1)
			{
				var items = this.ItemsSource as AppointmentSlotCollection;
				Debug.Assert(items != null, "Items shouldn't be null.");

				var selectedAppointmentSlot = this.SelectedItems[0] as AppointmentSlot;
				Debug.Assert(selectedAppointmentSlot != null, "Selected appointment slot shouldn't be null.");

				Comparison<AppointmentSlot> appointmentComparison =
					(a, b) => a.TimeSlot.Start.CompareTo(b.TimeSlot.Start);
				List<AppointmentSlot> appointmentSlots =
					items.GetElementsByOccurrence(selectedAppointmentSlot.Occurrence).
						Where(a => a != selectedAppointmentSlot).ToList();
				appointmentSlots.Sort(appointmentComparison);

				// Insert appointments in the correct order
				if (appointmentSlots.Count > 0)
				{
					for (int i = 0; i < appointmentSlots.Count; i++)
					{
						int index = appointmentComparison(selectedAppointmentSlot, appointmentSlots[i]) > 0
										? i
										: i + 1;
						try
						{
							this.entranceCounter++;
							this.SelectedItems.Insert(index, appointmentSlots[i]);
						}
						finally
						{
							this.entranceCounter--;
						}
					}
				}
			}

			if (this.entranceCounter <= 0)
			{
				base.OnSelectionChanged(e);

				this.HandleAppointmentItemSelectionChanged(e);
			}
		}

		/// <summary>
		/// Handles changes to the <see cref="SelectedAppointments"/> property.
		/// </summary>
		private static void OnSelectedAppointmentsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((AppointmentItemsControl)d).OnSelectedAppointmentsChanged(e);
		}

		private AppointmentEditingEventArgs RaiseAppointmentEditingEvent(IAppointment appointment, AppointmentEditAction action)
		{
			var editingEventArgs = new AppointmentEditingEventArgs(
				RadScheduler.AppointmentEditingEvent, appointment);
			editingEventArgs.AppointmentEditAction = action;
			this.RaiseEvent(editingEventArgs);

			return editingEventArgs;
		}
		
		private void OnAppointmentItemsControlDragQuery(object sender, DragDropQueryEventArgs e)
		{
			////TODO: change the following code for the SP.

			var button = e.GetElement<ButtonBase>(e.Options.CurrentDragPoint);
			if (button == null)
			{
				e.QueryResult = !this.Scheduler.IsReadOnly && !this.IsResizing;
			}
			else
			{
				e.QueryResult = false;
			}

			if (e.QueryResult == true && e.Options.u_IsStatus)
			{
				this.IsDragging = true;
				var item = e.Options.Source as AppointmentItem;
				var editingEvent = this.RaiseAppointmentEditingEvent(item.AppointmentSlot.Occurrence.Appointment, AppointmentEditAction.Drag);
				if (!editingEvent.Cancel)
				{
					e.Options.Payload = e.Options.Source;
					ContentControl cue = new ContentControl();
					cue.ContentTemplate = item.Scheduler.DragVisualCueTemplate;
					cue.Content = new DragVisualCue(item.AppointmentSlot.Occurrence.Appointment, true);
					cue.Width = item.ActualWidth;
					cue.MinHeight = item.ActualHeight;
					cue.HorizontalContentAlignment = HorizontalAlignment.Stretch;
					cue.VerticalContentAlignment = VerticalAlignment.Stretch;
					e.Options.DragCue = cue;

					TimeSlotItem timeslotItem = e.GetElement<TimeSlotItem>(e.Options.MouseClickPoint);
					if (timeslotItem == null)
					{
						e.QueryResult = false;
						this.IsDragging = false;
						return;
					}
					TimeSlot sl = timeslotItem.TimeSlot;
					TimeSlot apps = (item.Content as AppointmentSlot).TimeSlot;
					if (this.Scheduler != null)
					{
						this.Scheduler.DroppedAppointmentDuration = (sl.Start - apps.Start).Duration();
					}
				}
				else
				{
					this.IsDragging = true;
					e.QueryResult = false;
				}
			}
		}

		private void HandleAppointmentItemSelectionChanged(System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (!this.shouldUpdateSelectedAppointments)
			{
				return;
			}

			var selectedAppointments = this.SelectedAppointments as SelectedAppointmentCollection;
			if (selectedAppointments == null)
			{
				return;
			}

			using (selectedAppointments.DeferRefresh())
			{
				IEnumerable<IAppointment> added = from AppointmentSlot slot in e.AddedItems
												  group slot by slot.Occurrence.Master
													  into grouped
													  select grouped.Key;

                if (added.Count() > 0)
                {
                    this.previoslySelectedItems = added;
                }

				IEnumerable<IAppointment> removed = from AppointmentSlot slot in e.RemovedItems
													group slot by slot.Occurrence.Master
														into grouped
														select grouped.Key;

				foreach (IAppointment appointment in added)
				{
					selectedAppointments.AddIfNotPresent(appointment);
				}

				foreach (IAppointment appointment in removed)
				{

                    // The following check is not to unselect recurrent appointments  
                    // if it is already selected and user clicks on it
                    if (appointment.IsRecurring())
                    {
                        if (this.previoslySelectedItems != null && !this.previoslySelectedItems.Contains(appointment))
                        {
                            selectedAppointments.Remove(appointment);
                        }
                    }
                    else
                    {
                        selectedAppointments.Remove(appointment);
                    }

				}
			}
		}

		private void OnSelectedAppointmentsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.SetSelection();
		}

		private void SetSelection()
		{
			if (this.SelectedAppointments == null)
			{
				return;
			}

			try
			{
				this.shouldUpdateSelectedAppointments = false;

				var slotsToSelect =
					from AppointmentSlot slot in this.Items
					where this.SelectedAppointments.Contains(slot.Occurrence.Master)
					select slot;

				this.SelectItems(slotsToSelect);
			}
			finally
			{
				this.shouldUpdateSelectedAppointments = true;
			}
		}
	}
}