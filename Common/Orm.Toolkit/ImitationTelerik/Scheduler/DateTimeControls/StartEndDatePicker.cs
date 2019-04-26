using System;
using System.Windows;

using Orm.Toolkit.ImitationTelerik;

namespace Orm.Toolkit.Telerik.Windows.Controls
{  
    /// <summary>
    /// Holds attached properties that can be used to make two <see cref="DateTimePicker"/> behave like start end ones.
    /// </summary>
    public static class StartEndDatePicker
    {
        /// <summary>
        /// Identifies the <c>EndPicker</c> attached property.
        /// </summary>
        /// <returns>The identifier for the <c>EndPicker</c> property</returns>
        public static readonly DependencyProperty EndPickerProperty =
            DependencyProperty.RegisterAttached(
                "EndPicker",
                typeof(DateTimePicker),
                typeof(StartEndDatePicker),
                new PropertyMetadata(null, OnEndPickerChanged));

        internal static readonly DependencyProperty StartEndDateControlBehaviorProperty =
            DependencyProperty.RegisterAttached(
                "StartEndDateControlBehavior", typeof(StartEndDateControlBehavior), typeof(StartEndDatePicker), null);

        /// <summary>
        /// Gets the value of the <c>EndPicker</c> attached property to given <see cref="DateTimePicker"/>.
        /// </summary>
        /// <param name="startPicker">The picker from which to read the attached property.</param>
        /// <returns>The value of the <c>EndPicker</c> attached property.</returns>
        public static DateTimePicker GetEndPicker(DependencyObject startPicker)
        {
            return (DateTimePicker)startPicker.GetValue(EndPickerProperty);
        }

        /// <summary>
        /// Sets the value of the <c>EndPicker</c> attached property to given <see cref="DateTimePicker"/>.
        /// </summary>
        /// <param name="startPicker">The start date picker on which the end picker will be attached.</param>
        /// <param name="endPicker">The end picker that will be attached.</param>
        public static void SetEndPicker(DependencyObject startPicker, DateTimePicker endPicker)
        {
            startPicker.SetValue(EndPickerProperty, endPicker);
        }

        private static void OnEndDateInvalidated(object sender, EventArgs e)
        {
            MessageBox.Show(Strings.EndDateBeforeStart);
        }

        private static void OnEndPickerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var startPicker = d as DateTimePicker;
            if (startPicker == null)
            {
                return;
            }

            var endPicker = e.NewValue as DateTimePicker;

            var behavior = startPicker.GetValue(StartEndDateControlBehaviorProperty) as StartEndDateControlBehavior;

            // Clear existing behavior
            if (behavior != null)
            {
                if (endPicker == null)
                {
                    behavior.Detach();
                    behavior.EndDateInvalidated -= OnEndDateInvalidated;
                    startPicker.SetValue(StartEndDateControlBehaviorProperty, null);
                }
                else
                {
                    behavior.EndControl = endPicker;
                }
            }
            else
            {
                if (endPicker != null)
                {
                    behavior = new StartEndDateControlBehavior(startPicker, endPicker);
                    behavior.Attach();
                    behavior.EndDateInvalidated += OnEndDateInvalidated;

                    startPicker.SetValue(StartEndDateControlBehaviorProperty, behavior);
                }
            }
        }
    }
}