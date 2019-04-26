using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{   
    /// <summary>
    /// The visual representation of resource group.
    /// </summary>
    public class AppointmentsControlsContainerItem : Control
    {
        /// <summary>
        /// Identifies the <see cref="AttachedScrollBarProperty"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="AttachedScrollBarProperty"/> property.</returns>
        public static readonly DependencyProperty AttachedScrollBarProperty =
        DependencyProperty.Register("AttachedScrollBar",
                                    typeof(ScrollBar),
                                    typeof(AppointmentsControlsContainerItem),
                                    new PropertyMetadata(OnAttachedScrollBarPropertyChanged));

        /// <summary>
        /// Identifies the <see cref="ResourceGroupProperty"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="ResourceGroupProperty"/> property.</returns>
        public static readonly DependencyProperty ResourceGroupProperty =
        DependencyProperty.Register("ResourceGroup", typeof(ResourceGroup), typeof(AppointmentsControlsContainerItem), new PropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="TimeSlotsProperty"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="TimeSlotsProperty"/> property.</returns>
		public static readonly DependencyProperty TimeSlotsProperty =
		DependencyProperty.Register("TimeSlots", typeof(TimeSlotCollectionView), typeof(AppointmentsControlsContainerItem), new PropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="AppointmentsProperty"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="AppointmentsProperty"/> property.</returns>
		public static readonly DependencyProperty AppointmentsProperty =
		DependencyProperty.Register("Appointments", typeof(AppointmentCollectionView), typeof(AppointmentsControlsContainerItem), new PropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="NotAllDayTimeSlotsProperty"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="NotAllDayTimeSlotsProperty"/> property.</returns>
		public static readonly DependencyProperty NotAllDayTimeSlotsProperty =
		DependencyProperty.Register("NotAllDayTimeSlots", typeof(TimeSlotCollectionView), typeof(AppointmentsControlsContainerItem), new PropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="AllDayTimeSlotsProperty"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="AllDayTimeSlotsProperty"/> property.</returns>
		public static readonly DependencyProperty AllDayTimeSlotsProperty =
		DependencyProperty.Register("AllDayTimeSlots", typeof(TimeSlotCollectionView), typeof(AppointmentsControlsContainerItem), new PropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="ShowHeadersProperty"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="ShowHeadersProperty"/> property.</returns>
		public static readonly DependencyProperty ShowHeadersProperty =
		DependencyProperty.Register("ShowHeaders", typeof(bool), typeof(AppointmentsControlsContainerItem), new PropertyMetadata(true));

        private const string AllDayScrollViewerName = "PART_AllDayScrollViewer";
        private const string AllDayAppointmentsControlName = "AllDayAppointmentsControl";
        private AppointmentsControlsContainer parentAppointmentsControlsContainer;

        private ScrollViewer allDayScrollViewer;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentsControlsContainerItem"/> class.
        /// </summary>
        public AppointmentsControlsContainerItem()
        {
            this.DefaultStyleKey = typeof(AppointmentsControlsContainerItem);
        }

        /// <summary>
        /// Gets all day appointments control.
        /// </summary>
        /// <value>All day appointments control.</value>
        public AppointmentsControl AllDayAppointmentsControl
        {
            get
			{
                return this.GetTemplateChild(AllDayAppointmentsControlName) as AppointmentsControl;
			}
        }

        /// <summary>
        /// Gets the All Day ScrollViewer if existing.
        /// </summary>
        /// <value>The All Day ScrollViewer if existing, else null.</value>
        public ScrollViewer AllDayScrollViewer
        {
            get
            {
                return this.allDayScrollViewer;
            }
        }

        /// <summary>
        /// Gets or sets the attached scroll bar.
        /// </summary>
        /// <value>The attached scroll bar.</value>
        public ScrollBar AttachedScrollBar
        {
            get
			{
				return (ScrollBar)GetValue(AttachedScrollBarProperty);
			}
            set
			{
				SetValue(AttachedScrollBarProperty, value);
			}
        }

		/// <summary>
		/// Gets or sets the TimeSlots.
		/// </summary>
		/// <value>The TimeSlots.</value>
		public TimeSlotCollectionView TimeSlots
		{
			get
			{
				return (TimeSlotCollectionView)GetValue(TimeSlotsProperty);
			}
			set
			{
				SetValue(TimeSlotsProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the Appointments.
		/// </summary>
		/// <value>The appointments.</value>
		public AppointmentCollectionView Appointments
		{
			get
			{
				return (AppointmentCollectionView)GetValue(AppointmentsProperty);
			}
			set
			{
				SetValue(AppointmentsProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the NotAllDayTimeSlots.
		/// </summary>
		/// <value>The not all-day TimeSlots.</value>
		public TimeSlotCollectionView NotAllDayTimeSlots
		{
			get
			{
				return (TimeSlotCollectionView)GetValue(NotAllDayTimeSlotsProperty);
			}
			set
			{
				SetValue(NotAllDayTimeSlotsProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the AllDayTimeSlots.
		/// </summary>
		/// <value>The All Day TimeSlots.</value>
		public TimeSlotCollectionView AllDayTimeSlots
		{
			get
			{
				return (TimeSlotCollectionView)GetValue(AllDayTimeSlotsProperty);
			}
			set
			{
				SetValue(AllDayTimeSlotsProperty, value);
			}
		}

		/// <summary>
		/// Indicates shuulf the headers gor the groups to be dispalyed.
		/// </summary>
		/// <value>The value of ShowHeaders property.</value>
		public bool ShowHeaders
		{
			get
			{
				return (bool)GetValue(ShowHeadersProperty);
			}
			set
			{
				SetValue(ShowHeadersProperty, value);
			}
		}

        /// <summary>
        /// Gets or sets the resource group.
        /// </summary>
        /// <value>The Resource Group.</value>
        public ResourceGroup ResourceGroup
        {
            get
			{
				return (ResourceGroup)GetValue(ResourceGroupProperty);
			}
            set
			{
				SetValue(ResourceGroupProperty, value);
			}
        }

        /// <summary>
        /// Gets the parent appointments controls container.
        /// </summary>
        /// <value>The parent appointments controls container.</value>
        public AppointmentsControlsContainer ParentAppointmentsControlsContainer
        {
            get 
            {
                return this.parentAppointmentsControlsContainer; 
            }
        }        

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes call <see cref="M:System.Windows.FrameworkElement.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

			var scheduler = this.ParentOfType<RadScheduler>();
            this.parentAppointmentsControlsContainer = this.GetParent<AppointmentsControlsContainer>();
            this.allDayScrollViewer = this.GetTemplateChild(AllDayScrollViewerName) as ScrollViewer;
            
            if ((this.ParentAppointmentsControlsContainer.Scheduler.ViewMode == SchedulerViewMode.Week 
				 || this.ParentAppointmentsControlsContainer.Scheduler.ViewMode == SchedulerViewMode.Day)
                && this.AllDayScrollViewer != null)
            {
                this.AllDayScrollViewer.SizeChanged += this.OnAllDayScrollViewerSizeChanged;

				this.AllDayScrollViewer.SetBinding(ScrollViewer.HeightProperty,
				new Binding("AllDayAreaHeight") { Source = scheduler, Mode = BindingMode.TwoWay });
                this.AllDayScrollViewer.LayoutUpdated += new EventHandler(this.OnAllDayScrollViewerLayoutUpdated);

            }

			this.SetBinding(
				AppointmentsControlsContainerItem.ShowHeadersProperty,
				new Binding("View.IsGrouped") { Source = scheduler, Mode = BindingMode.OneWay });

			this.SetBinding(
			AppointmentsControlsContainerItem.TimeSlotsProperty,
			new Binding("View.TimeSlotsView") { Source = scheduler, Mode = BindingMode.OneWay });

				this.SetBinding(
			AppointmentsControlsContainerItem.AppointmentsProperty,
			new Binding("Appointments") { Source = this.ResourceGroup, Mode = BindingMode.OneTime });

				this.SetBinding(
			AppointmentsControlsContainerItem.AllDayTimeSlotsProperty,
			new Binding("View.AllDayTimeSlotsView") { Source = scheduler, Mode = BindingMode.OneWay });


			ItemsControl verticalHeaders = this.GetChildByName("PART_VerticalHeaders") as ItemsControl;
			if (verticalHeaders == null)
			{
				verticalHeaders = this.GetChildByName("DayHeaderList") as ItemsControl;
			}
			
			if (verticalHeaders != null)
			{
				Binding bd = new Binding("TimeSlots.Groups");
				bd.Mode = BindingMode.OneTime;
				bd.RelativeSource = RelativeSource.TemplatedParent;
				verticalHeaders.SetBinding(ItemsControl.ItemsSourceProperty, bd);
			}

			ItemsControl horizontalHeaders = this.GetChildByName("PART_HorizontalHeaders") as ItemsControl;
			if (horizontalHeaders != null)
			{
				Binding bd = new Binding("TimeSlots.FirstGroupItemsHeaders");
				bd.Mode = BindingMode.OneTime;
				bd.RelativeSource = RelativeSource.TemplatedParent;
				horizontalHeaders.SetBinding(ItemsControl.ItemsSourceProperty, bd);
			}


        }

        private static void OnAttachedScrollBarPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            (sender as AppointmentsControlsContainerItem).OnAttachedScrollBarChanged(args);
        }


        private void OnAllDayScrollViewerLayoutUpdated(object sender, EventArgs e)
        {
            if (this.AllDayScrollViewer != null && this.AllDayScrollViewer.ViewportHeight > 0.0)
            {
                this.ParentAppointmentsControlsContainer.SetAttachedScrollBarState();
                this.AllDayScrollViewer.LayoutUpdated -= this.OnAllDayScrollViewerLayoutUpdated;
            }
        }


        private void OnAllDayScrollViewerSizeChanged(object sender, SizeChangedEventArgs e)
        {

            if (this.allDayScrollViewer == null)
            {
                this.allDayScrollViewer = this.GetTemplateChild(AllDayScrollViewerName) as ScrollViewer;
            }
            Dispatcher.BeginInvoke(new Action(() => this.ParentAppointmentsControlsContainer.SetAttachedScrollBarState()));

        }

        private void OnAttachedScrollBarChanged(DependencyPropertyChangedEventArgs args)
        {
            var newScrollBar = args.NewValue as ScrollBar;
            if (newScrollBar != null)
            {
                newScrollBar.ValueChanged += new RoutedPropertyChangedEventHandler<double>(this.OnScrollBarValueChanged);
            }
        }

        private void OnScrollBarValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var scrollBar = sender as ScrollBar;

            if (scrollBar.Orientation == Orientation.Vertical)
            {
                this.AllDayScrollViewer.ScrollToVerticalOffset(e.NewValue * this.AllDayScrollViewer.ScrollableHeight);
            }
        }
    }
}
