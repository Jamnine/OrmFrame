using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Serves as a base class for all view definitions. Contains common properties for all views.
    /// </summary>
    public abstract class ViewDefinitionBase : DependencyObject
    {
        /// <summary>
        /// Identifies the <see cref="LargeChangeInterval"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="LargeChangeInterval"/> property.</returns>
        public static readonly DependencyProperty LargeChangeIntervalProperty =
            DependencyProperty.Register(
                "LargeChangeInterval",
                typeof(DateTimeInterval),
                typeof(ViewDefinitionBase),
                new PropertyMetadata(DateTimeInterval.Zero));

        /// <summary>
        /// Identifies the <see cref="SmallChangeInterval"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="SmallChangeInterval"/> property.</returns>
        public static readonly DependencyProperty SmallChangeIntervalProperty =
            DependencyProperty.Register(
                "SmallChangeInterval",
                typeof(DateTimeInterval),
                typeof(ViewDefinitionBase),
                new PropertyMetadata(DateTimeInterval.Zero));

        /// <summary>
        /// Identifies the <see cref="TimeSlotLength"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="TimeSlotLength"/> property.</returns>
        public static readonly DependencyProperty TimeSlotLengthProperty =
            DependencyProperty.Register(
                "TimeSlotLength",
                typeof(TimeSpan),
                typeof(ViewDefinitionBase),
                new PropertyMetadata(TimeSpan.Zero, OnTimeSlotLengthPropertyChanged));        

        /// <summary>
        /// Identifies the <see cref="VisibleDays"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="VisibleDays"/> property.</returns>
        public static readonly DependencyProperty VisibleDaysProperty =
            DependencyProperty.Register(
                "VisibleDays",
                typeof(int),
                typeof(ViewDefinitionBase),
                new PropertyMetadata(0, OnVisibleDaysPropertyChanged));

        private ReadOnlyCollection<PropertyGroupDescription> groupDescriptions;
        private bool initilized;

        /// <summary>
        /// Occurs when view definition is changed.
        /// </summary>
        public event EventHandler ViewDefinitionChanged;

        /// <summary>
        /// Gets or sets large change interval. It indicates date time interval with which current view will be
        /// increased or decreased. This is a dependency property.
        /// </summary>
        /// <returns><see cref="DateTimeInterval"/> for large change. The default value is <see cref="DateTimeInterval.Zero"/>.</returns>  
        public virtual DateTimeInterval LargeChangeInterval
        {
            get
            {
                return (DateTimeInterval)this.GetValue(LargeChangeIntervalProperty);
            }
            set
            {
                this.SetValue(LargeChangeIntervalProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets small change interval. It indicates date time interval with which current view will be
        /// increased or decreased. This is a dependency property.
        /// </summary>
        /// <returns><see cref="DateTimeInterval"/> for small change. The default value is <see cref="DateTimeInterval.Zero"/>.</returns>  
        public virtual DateTimeInterval SmallChangeInterval
        {
            get
            {
                return (DateTimeInterval)this.GetValue(SmallChangeIntervalProperty);
            }
            set
            {
                this.SetValue(SmallChangeIntervalProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets time slot length. This property indicates how long should be the time slots. 
        /// This is a dependency property.
        /// </summary>
        /// <returns>The length of the time slots. The default value is <see cref="TimeSpan.Zero"/>.</returns>  
        public virtual TimeSpan TimeSlotLength
        {
            get
            {
                return (TimeSpan)this.GetValue(TimeSlotLengthProperty);
            }
            set
            {
                this.SetValue(TimeSlotLengthProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets visible days count for this view. It indicates how many dates this view will display.
        /// This is a dependency property.
        /// </summary>
        /// <returns>Visible days count for this view. The default value is 0.</returns>  
        public virtual int VisibleDays
        {
            get
            {
                return (int)this.GetValue(VisibleDaysProperty);
            }
            set
            {
                this.SetValue(VisibleDaysProperty, value);
            }
        }

        internal ReadOnlyCollection<PropertyGroupDescription> GroupDescriptions
        {
            get
            {
                if (!this.initilized)
                {
                    var desriptors = new List<PropertyGroupDescription>(this.GetGroupDescriptions());
                    this.groupDescriptions = new ReadOnlyCollection<PropertyGroupDescription>(desriptors);

                    this.initilized = true;
                }
                return this.groupDescriptions;
            }
        }

        /// <summary>
        /// Generates the time slots from this definition.
        /// </summary>
        /// <returns>Time slots generated using this definition properties.</returns>
        public virtual IEnumerable<TimeSlot> GenerateTimeSlots(DateTime startDate)
        {
            long totalTicks = TimeSpan.FromDays(this.VisibleDays).Ticks;

            for (long i = 0; i < totalTicks; i += this.TimeSlotLength.Ticks)
            {
                var timeSlot = new TimeSlot(startDate.AddTicks(i), this.TimeSlotLength);

                yield return timeSlot;
            }
        }

        /// <summary>
        /// Gets the group descriptions.
        /// </summary>
        /// <returns></returns>
        protected internal virtual IEnumerable<PropertyGroupDescription> GetGroupDescriptions()
        {
            yield break;
        }

        /// <summary>
        /// Raises the <see cref="ViewDefinitionChanged"/> event.
        /// </summary>
        /// <param name="args">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnViewDefinitionChanged(EventArgs args)
        {
            if (this.ViewDefinitionChanged != null)
            {
                this.ViewDefinitionChanged(this, args);
            }
        }

		/// <summary>
		/// Called when [time slot length changed].
		/// </summary>
		protected virtual void OnTimeSlotLengthChanged()
		{
			this.OnViewDefinitionChanged(EventArgs.Empty);
		}

        private static void OnTimeSlotLengthPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ViewDefinitionBase)d).OnTimeSlotLengthChanged();
        }

        private static void OnVisibleDaysPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ViewDefinitionBase)d).OnVisibleDaysChanged();
        }

        private void OnVisibleDaysChanged()
        {
            this.OnViewDefinitionChanged(EventArgs.Empty);
        }
    }
}