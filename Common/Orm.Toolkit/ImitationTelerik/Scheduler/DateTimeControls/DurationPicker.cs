using System;
using System.Collections.Generic;

using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents an editable <see cref="ComboBox"/> control showing predefined time
    /// durations in minutes, hours, days and weeks.
    /// </summary>
    public class DurationPicker : RadComboBox

    {
        /// <summary>
        /// Identifies the <see cref="SelectedDuration"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="SelectedDuration"/> property.</returns>
        public static readonly DependencyProperty SelectedDurationProperty =
            DependencyProperty.Register(
                "SelectedDuration",
                typeof(TimeSpan),
                typeof(DurationPicker),
                new PropertyMetadata(TimeSpan.Zero, OnSelectedDurationChanged));

        /// <summary>
        /// The predefined values that fill in the <see cref="ComboBox"/> by default.
        /// </summary>
        private static readonly List<TimeSpan> values = new List<TimeSpan>
                                                            {
                                                                TimeSpan.FromMinutes(0),
                                                                TimeSpan.FromMinutes(5),
                                                                TimeSpan.FromMinutes(10),
                                                                TimeSpan.FromMinutes(15),
                                                                TimeSpan.FromMinutes(30),
                                                                TimeSpan.FromHours(1),
                                                                TimeSpan.FromHours(2),
                                                                TimeSpan.FromHours(3),
                                                                TimeSpan.FromHours(4),
                                                                TimeSpan.FromHours(5),
                                                                TimeSpan.FromHours(6),
                                                                TimeSpan.FromHours(7),
                                                                TimeSpan.FromHours(8),
                                                                TimeSpan.FromHours(9),
                                                                TimeSpan.FromHours(10),
                                                                TimeSpan.FromHours(11),
                                                                TimeSpan.FromDays(0.5),
                                                                TimeSpan.FromHours(18),
                                                                TimeSpan.FromDays(1),
                                                                TimeSpan.FromDays(2),
                                                                TimeSpan.FromDays(3),
                                                                TimeSpan.FromDays(4),
                                                                TimeSpan.FromDays(7),
                                                                TimeSpan.FromDays(14)
                                                            };

        /// <summary>
        /// Initializes static members of the <see cref="DurationPicker"/> class.
        /// </summary>
        static DurationPicker()
        {
            IsEditableProperty.OverrideMetadata(
                typeof(DurationPicker),
                new FrameworkPropertyMetadata(BooleanBoxes.TrueBox));
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="DurationPicker"/> class.
        /// </summary>
        public DurationPicker()
        {

            this.Items.AddRange(values.Select(v => DurationHelper.TimeSpanToString(Language.GetEquivalentCulture(), v)));

        }

        /// <summary>
        /// Gets or sets currently selected duration. This is a dependency property.
        /// </summary>
        /// <returns>Selected duration. The default value is <see cref="TimeSpan.Zero"/></returns>  
        public TimeSpan SelectedDuration
        {
            get
            {
                return (TimeSpan)this.GetValue(SelectedDurationProperty);
            }
            set
            {
                this.SetValue(SelectedDurationProperty, value);
            }
        }

        /// <summary>
        /// Called when ApplyTemplate is called. 
        /// </summary>
        public override void OnApplyTemplate()
        {
            var window = this.GetParent<RadWindow>();
            if (window != null)
            {
                StyleManager.SetThemeFromParent(this, window);
            } 

            base.OnApplyTemplate();

            var box = this.GetTemplateChild("PART_EditableTextBox") as TextBox;
            if (box != null)
            {
                box.LostFocus += this.OnEditableTextBoxLostFocus;
            }
        }

        /// <summary>
        /// Updates the text of the editable text box when <see cref="SelectedDuration"/> is changed.
        /// </summary>
        protected virtual void OnSelectedDurationChanged(DependencyPropertyChangedEventArgs args)
        {

            this.Text = DurationHelper.TimeSpanToString(Language.GetEquivalentCulture(), (TimeSpan)args.NewValue);

        }

        /// <summary>
        /// Handles changes to the <see cref="SelectedDuration" />.
        /// </summary>
        private static void OnSelectedDurationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((DurationPicker)d).OnSelectedDurationChanged(e);
        }

        /// <summary>
        /// Called when the editable text box loses focus.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance
        /// containing the event data.</param>
        private void OnEditableTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            TimeSpan duration;

            if (DurationHelper.StringToTimeSpan(this.Text, Language.GetEquivalentCulture(), out duration))
            {
                this.SelectedDuration = duration;
            }
            this.Text = DurationHelper.TimeSpanToString(Language.GetEquivalentCulture(), this.SelectedDuration);

        }
    }
}