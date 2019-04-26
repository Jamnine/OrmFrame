using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// SchedulerPresenter serves as a main control in <see cref="RadScheduler"/> architecture.
    /// It is used to hold and display different views according to its View property.
    /// </summary>
    public class SchedulerPresenter : Control
    {
        /// <summary>
        /// Identifies the <see cref="Scheduler"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="Scheduler"/> property.</returns>
        public static readonly DependencyProperty SchedulerProperty =
            DependencyProperty.Register("Scheduler", typeof(RadScheduler), typeof(SchedulerPresenter), null);

        /// <summary>
        /// Identifies the <see cref="TimeSlotsView"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="TimeSlotsView"/> property.</returns>
        public static readonly DependencyProperty TimeSlotsViewProperty =
            DependencyProperty.Register("TimeSlotsView", typeof(TimeSlotCollectionView), typeof(SchedulerPresenter), null);

        /// <summary>
        /// Gets the <see cref="AppointmentsControl"/> that are displayed.
        /// </summary>
        private IList<AppointmentsControl> schedulerAppointmentsControls = new List<AppointmentsControl>();
        private ScrollViewer notAllDayAppScrollViewer;
        private TimeRuler timeRuler;
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerPresenter"/> class.
        /// </summary>
        public SchedulerPresenter()
        {
            this.SetBinding(TimeSlotsViewProperty, new Binding("Scheduler.View.TimeSlotsView") { Source = this });

        }

        /// <summary>
        /// Gets the scheduler appointments controls.
        /// </summary>
        /// <value>The scheduler appointments controls.</value>
        public IList<AppointmentsControl> SchedulerAppointmentsControls
        {
            get
            {
                return this.schedulerAppointmentsControls;
            }
        }

        /// <summary>
        /// Gets or sets parent scheduler for the presenter. This is a dependency property.
        /// </summary>
        /// <returns>The parent scheduler for this presenter. The default value is null</returns>  
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

        /// <summary>
        /// Gets or sets the TimeSlotsView property.
        /// The default value is null. This is a dependency property.
        /// </summary>
        public TimeSlotCollectionView TimeSlotsView
        {
            get
            {
                return (TimeSlotCollectionView)this.GetValue(TimeSlotsViewProperty);
            }
            set
            {
                this.SetValue(TimeSlotsViewProperty, value);
            }
        }

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {
			this.ClearOldAppointmentsControls();

            base.OnApplyTemplate();

			ItemsControl horizontalHeaders = this.GetChildByName("HorizontalHeaders") as ItemsControl;
			if (horizontalHeaders != null)
			{
				Binding bd = new Binding("TimeSlotsView.FirstGroupItems");
				bd.RelativeSource = RelativeSource.TemplatedParent;
				horizontalHeaders.SetBinding(ItemsControl.ItemsSourceProperty, bd);
			}
            this.notAllDayAppScrollViewer = this.GetChildByName("NotAllDayAppScrollViewer") as ScrollViewer;
            this.timeRuler = this.GetChildByName("TimeRuler") as TimeRuler;
        }

        public void ScrollVerticalOffset(TimeSpan timeSpan)
        {
            if (this.notAllDayAppScrollViewer != null && this.timeRuler != null)
            {
                if (this.notAllDayAppScrollViewer.IsVisible)
                {
                    var timeSlotsView = new TimeSlotCollectionView();
                    if (this.Scheduler.ViewMode == SchedulerViewMode.Week)
                    {
                        foreach (var item in this.TimeSlotsView.Take(this.TimeSlotsView.Count() / 7))
                        {
                            timeSlotsView.Add(item);
                        }
                    }
                    else if (this.Scheduler.ViewMode == SchedulerViewMode.Day)
                    {
                        timeSlotsView = this.TimeSlotsView;
                    }
                    var viewCount = timeSlotsView.Count;
                    var timeSolt = timeSlotsView.Where(t => TimeSpan.Parse(t.Start.ToString("HH:mm")) < timeSpan);
                    if (timeSolt.Count() > 0)
                    {
                        var index = timeSlotsView.IndexOf(timeSolt.Last());
                        var height = this.timeRuler.ActualHeight;
                        this.notAllDayAppScrollViewer.ScrollToVerticalOffset((height / viewCount) * index);
                    }
                    else
                    {
                        this.notAllDayAppScrollViewer.ScrollToTop();
                    }
                }
            }
        }

		internal void ClearOldAppointmentsControls()
		{
			foreach (AppointmentsControl control in this.schedulerAppointmentsControls)
			{
				control.Appointments = null;
				control.TimeSlots = null;
				control.AppointmentItemsControl.SelectedAppointments = null;
			}
			this.schedulerAppointmentsControls.Clear();
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

     }
}