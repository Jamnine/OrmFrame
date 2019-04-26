using System;
using System.Collections.Generic;
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
    /// This class is responsible for <see cref="AppointmentSlot"/> visualization. It handles Drag/Drop and Resize actions of <see cref="AppointmentSlot"/>.
    /// </summary>
    [TemplatePart(Name = ResizeStartElementName, Type = typeof(FrameworkElement))]
    [TemplatePart(Name = ResizeEndElementName, Type = typeof(FrameworkElement))]
    [TemplatePart(Name = DeleteButtonElementName, Type = typeof(FrameworkElement))]

    [TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
    [TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
    [TemplateVisualState(Name = "SelectedMouseOver", GroupName = "CommonStates")]

    [TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
    [TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]

    [TemplateVisualState(Name = "SingleOccurrence", GroupName = "OccurrenceStates")]
    [TemplateVisualState(Name = "Occurrence", GroupName = "OccurrenceStates")]
    [TemplateVisualState(Name = "Exception", GroupName = "OccurrenceStates")]

    [TemplateVisualState(Name = "Horizontal", GroupName = "OrientationStates")]
    [TemplateVisualState(Name = "Vertical", GroupName = "OrientationStates")]

    public class AppointmentItem : ListBoxItem
    {
        /// <summary>
        /// Identifies the <see cref="MouseOverBackground"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="MouseOverBackground"/> property.</returns>
        public static readonly DependencyProperty MouseOverBackgroundProperty =
       DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(AppointmentItem), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        /// Identifies the <see cref="MouseOverBackground"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="SelectedBackground"/> property.</returns>
        public static readonly DependencyProperty SelectedBackgroundProperty =
        DependencyProperty.Register("SelectedBackground", typeof(Brush), typeof(AppointmentItem), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        /// Identifies the <see cref="Scheduler"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="Scheduler"/> property.</returns>
        public static readonly DependencyProperty SchedulerProperty =
            DependencyProperty.Register("Scheduler", typeof(RadScheduler), typeof(AppointmentItem), null);

		/// <summary>
		/// Identifies the <see cref="Orientation"/> property.
		/// </summary>
		public static readonly DependencyProperty OrientationProperty =
			DependencyProperty.Register("Orientation", typeof(Orientation), typeof(AppointmentItem), new PropertyMetadata(Orientation.Horizontal, null, null));


        private const string ResizeEndElementName = "PART_ResizeEnd";
        private const string ResizeStartElementName = "PART_ResizeStart";
        private const string DeleteButtonElementName = "PART_DeleteButton";
        /// <summary>
        /// иак╦ add by Ben 2015-11-20 
        /// </summary>
        public bool IsFlickering
        {
            get { return (bool)GetValue(IsFlickeringProperty); }
            set { SetValue(IsFlickeringProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsFlickering.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsFlickeringProperty =
            DependencyProperty.Register("IsFlickering", typeof(bool), typeof(AppointmentItem), new PropertyMetadata(false));

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentItem"/> class.
        /// </summary>
        public AppointmentItem()
        {
			RadDragAndDropManager.AddDragInfoHandler(this, this.OnAppointmentItemDragInfo);
        }
		
        /// <summary>
        /// Gets the appointment slot.
        /// </summary>
        /// <value>The appointment slot.</value>
        public AppointmentSlot AppointmentSlot
        {
            get
            {
                return this.Content as AppointmentSlot;
            }
        }

        /// <summary>
        /// Gets or sets the mouse over background.
        /// </summary>
        /// <value>The mouse over background.</value>
        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the pressed background.
        /// </summary>
        /// <value>The pressed background.</value>
        public Brush SelectedBackground
        {
            get { return (Brush)GetValue(SelectedBackgroundProperty); }
            set { SetValue(SelectedBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the appointment Orientation.
        /// </summary>
        /// <value>The current Orientation.</value>
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(SelectedBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the <see cref="RadScheduler"/>. This is a dependency property.
        /// </summary>
        /// <returns>The current <see cref="RadScheduler"/>.The default value is null.</returns> 
        public RadScheduler Scheduler
        {
            get
            {
                return (RadScheduler)this.GetValue(SchedulerProperty);
            }
            set
            {
                this.SetValue(SchedulerProperty, value);
            }
        }

        internal AppointmentItemsControl ParentItemsControl
        {
            get
            {
                return ItemsControl.ItemsControlFromItemContainer(this) as AppointmentItemsControl;
            }
        }

        internal FrameworkElement ResizeEndElement { get; private set; }
        internal FrameworkElement ResizeStartElement { get; private set; }
        internal FrameworkElement DeleteButtontElement { get; private set; }

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes call <see cref="M:System.Windows.FrameworkElement.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {
			base.OnApplyTemplate();

			var appointmentsControl = this.ParentOfType<AppointmentsControl>();
			if (appointmentsControl != null)
			{
				this.Scheduler = this.ParentOfType<RadScheduler>();

				this.UpdateIsDraggable();

				this.DetachFromVisualTree();
				this.AttachToVisualTree();
				this.DefineAppointmentColors();
			}
        }

		internal void UpdateProperties()
		{
			this.UpdateIsSelected();
			this.UpdateIsDraggable();
			this.DetachFromVisualTree();
			this.AttachToVisualTree();
			this.DefineAppointmentColors();

		}

		internal void UpdateIsSelected()
		{
			var slot = this.Content as AppointmentSlot;
			if (this.Scheduler != null && this.Scheduler.SelectedAppointments.Contains(slot.Occurrence.Appointment))
			{
				this.IsSelected = true;
			}
		}



		/// <summary>
		/// Called when the value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property changes.
		/// </summary>
		/// <param name="oldContent">The old value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property.</param>
		/// <param name="newContent">The new value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property.</param>
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			base.OnContentChanged(oldContent, newContent);

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



		private void UpdateIsDraggable()
		{
			if (!this.AppointmentSlot.Occurrence.CanResizeOrMove())
			{
				this.SetValue(RadDragAndDropManager.AllowDragProperty, false);
			}
			else
			{
				this.SetBinding(
				  RadDragAndDropManager.AllowDragProperty, new Binding("Scheduler.IsReadOnly") { Source = this, Converter = new InvertedBooleanConverter() });
			}
		}

        private void AttachToVisualTree()
        {
            if (this.ParentItemsControl == null)
            {
                return;
            }

            var outerBorder = this.GetTemplateChild("outMostBorder") as FrameworkElement;
            if (outerBorder != null && this.Scheduler.IsReadOnly)
            {
                outerBorder.Cursor = null;
            }

            List<AppointmentSlot> appointmentSlots =
                (from a in (AppointmentSlotCollection)this.ParentItemsControl.ItemsSource
                 where a.Occurrence == this.AppointmentSlot.Occurrence
                 orderby a.TimeSlot.Start ascending
                 select a).ToList();
            bool isFirst = this.AppointmentSlot == appointmentSlots.First();
            bool isLast = this.AppointmentSlot == appointmentSlots.Last();
            bool canResize = this.AppointmentSlot.Occurrence.CanResizeOrMove();
            this.ResizeStartElement = this.GetTemplateChild(ResizeStartElementName) as FrameworkElement;
            if (this.ResizeStartElement != null)
            {
                if (!canResize || this.Scheduler.IsReadOnly)
                {
                    this.ResizeStartElement.Visibility = Visibility.Collapsed;
                }
                else
                {
                    if (isFirst)
                    {
                        this.ResizeStartElement.AddMouseDownHandler(this.OnResizeElementMouseDown);
						this.ResizeStartElement.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        this.ResizeStartElement.Visibility = Visibility.Collapsed;
                    }
                }
            }

            this.ResizeEndElement = this.GetTemplateChild(ResizeEndElementName) as FrameworkElement;
            if (this.ResizeEndElement != null)
            {
                if (!canResize || this.Scheduler.IsReadOnly)
                {
                    this.ResizeEndElement.Visibility = Visibility.Collapsed;
                }
                else
                {
                    if (isLast)
                    {
                        this.ResizeEndElement.AddMouseDownHandler(this.OnResizeElementMouseDown);
						this.ResizeEndElement.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        this.ResizeEndElement.Visibility = Visibility.Collapsed;
                    }
                }
            }
        }

        private void DetachFromVisualTree()
        {
            if (this.ResizeStartElement != null)
            {
                this.ResizeStartElement.RemoveMouseDownHandler(this.OnResizeElementMouseDown);
            }

            if (this.ResizeEndElement != null)
            {
                this.ResizeEndElement.RemoveMouseDownHandler(this.OnResizeElementMouseDown);
            }
        }

        private void DefineAppointmentColors()
        {
			if (this.Scheduler != null && this.Scheduler.View.IsGrouped)
            {
                ResourceGroup group = this.ParentItemsControl.DataContext as ResourceGroup;
                if (group.Resource != null && group.ResourceStyleMapping != null)
                {
                    this.MouseOverBackground = group.ResourceStyleMapping.MouseOverAppointmentBrush;
                    this.SelectedBackground = group.ResourceStyleMapping.SelectedAppointmentBrush;
                    this.Background = group.ResourceStyleMapping.AppointmentBrush;
                }
            }
            AppointmentSlot app = this.DataContext as AppointmentSlot;
			if (app != null)
			{
				var appointment = app.Occurrence.Appointment as AppointmentBase;
				if (appointment != null && appointment.Category != null)
				{
					this.SelectedBackground = this.MouseOverBackground = this.Background = appointment.Category.CategoryBrush;
                }
                this.IsFlickering = appointment.IsFlickering;
                this.IsEnabled = appointment.CanEdit;
			}
        }

        private void OnResizeElementMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.ParentItemsControl.ResizeManager.OnAppointmentResizeElementMouseDown(this, sender, e);
        }

		private void OnAppointmentItemDragInfo(object sender, DragDropEventArgs e)
		{
			if (e.Options.Status == DragStatus.DragCancel)
			{
				TimeSlotItemsControl.ChangeAllDraggedItemsOpacity(this);
				if (this.ParentItemsControl != null && this.ParentItemsControl.TimeSlotItemsControl != null)
				{
					this.ParentItemsControl.TimeSlotItemsControl.ClearAllItemsIsDropPossibleProperty();
				}
			}
			else if (e.Options.Status == DragStatus.DragInProgress)
			{
				if (Keyboard.Modifiers != ModifierKeys.Control)
				{
					var draggedAppointmentItems = from app in this.ParentItemsControl.AppointmentItems
												  where app != null && app.AppointmentSlot.Occurrence.Appointment == this.AppointmentSlot.Occurrence.Appointment
												  select app;

					foreach (var app in draggedAppointmentItems)
					{
						app.Opacity = 0;
					}
				}
			}
		}
    }
}