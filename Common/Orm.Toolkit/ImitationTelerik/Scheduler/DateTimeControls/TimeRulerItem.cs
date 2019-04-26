using System.Windows;
using System.Windows.Controls;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents a TimeRulerItem control.
    /// </summary>
    public class TimeRulerItem : ContentControl
    {
        /// <summary>
        /// Identifies the <see cref="TimeIndicator"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="TimeIndicator"/> property.</returns>
        public static readonly DependencyProperty TimeIndicatorProperty =
            DependencyProperty.Register("TimeIndicator", typeof(string), typeof(TimeRulerItem), new FrameworkPropertyMetadata(string.Empty));

        /// <summary>
        /// Identifies the <see cref="TimeSlots"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="TimeSlots"/> property.</returns>
        public static readonly DependencyProperty TimeSlotsProperty =
            DependencyProperty.Register("TimeSlots", typeof(TimeSlotCollection), typeof(TimeRulerItem), new FrameworkPropertyMetadata(null));


        /// <summary>
        /// Gets or sets the TimeIndicator property. This is a dependency property.
        /// </summary>a
        /// <returns>string. The default value is string.Empty</returns>  
        public string TimeIndicator
        {
            get
            {
                return (string)this.GetValue(TimeIndicatorProperty);
            }
            set
            {
                this.SetValue(TimeIndicatorProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="TimeSlotsProperty"/>. This is a dependency property.
        /// </summary>
        /// <returns>The <see cref="TimeSlotsProperty"/>. The default value is null</returns>  
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public TimeSlotCollection TimeSlots
        {
            get
            {
                return (TimeSlotCollection)this.GetValue(TimeSlotsProperty);
            }
            set
            {
                this.SetValue(TimeSlotsProperty, value);
            }
        }


        /// <summary>
        /// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event. This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
        /// </summary>
        /// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
        protected override void OnInitialized(System.EventArgs e)
        {
            base.OnInitialized(e);
            this.DefaultStyleKey = ControlExtensions.GetDefaultStyleKey(this);
        }

    }
}