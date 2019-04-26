using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Time picker control.
    /// </summary>
    [TemplatePart(Name = ComboBoxName, Type = typeof(RadComboBox))]
    public class SchedulerTimePicker : Control
    {
        /// <summary>
        /// Identifies the <see cref="ItemConverterParameter"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="ItemConverterParameter"/> property.</returns>
        public static readonly DependencyProperty ItemConverterParameterProperty =
            DependencyProperty.Register(
                "ItemConverterParameter",
                typeof(object),
                typeof(SchedulerTimePicker),
                new PropertyMetadata("t", OnItemConverterParameterChanged));

        /// <summary>
        /// Identifies the <see cref="ItemConverter"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="ItemConverter"/> property.</returns>
        public static readonly DependencyProperty ItemConverterProperty =
            DependencyProperty.Register(
                "ItemConverter",
                typeof(IValueConverter),
                typeof(SchedulerTimePicker),
                new PropertyMetadata(new TimeToStringConverter(), OnItemConverterChanged));

        /// <summary>
        /// Identifies the <see cref="SelectedTime"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="SelectedTime"/> property.</returns>
        public static readonly DependencyProperty SelectedTimeProperty =
            DependencyProperty.Register(
                "SelectedTime",
                typeof(TimeSpan),
                typeof(SchedulerTimePicker),
                new PropertyMetadata(TimeSpan.Zero, OnSelectedTimeChanged));

        /// <summary>
        /// Identifies the <see cref="TimeSpanItems"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="TimeSpanItems"/> property.</returns>
        public static readonly DependencyProperty TimeSpanItemsProperty =
            DependencyProperty.Register(
                "TimeSpanItems",
                typeof(IEnumerable<TimeSpan>),
                typeof(SchedulerTimePicker),
                new PropertyMetadata(null, OnTimeSpanItemsChanged));

        private const string ComboBoxName = "PART_ComboBox";

        private RadComboBox combo;


        /// <summary>
        /// <see cref="SelectedTime"/> changed event.
        /// </summary>
        public event EventHandler SelectedTimeChanged;

        /// <summary>
        /// Gets or sets the item converter. This is a dependency property.
        /// </summary>
        /// <returns>Returns the item converter.</returns> 
        public IValueConverter ItemConverter
        {
            get
            {
                return (IValueConverter)this.GetValue(ItemConverterProperty);
            }
            set
            {
                this.SetValue(ItemConverterProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the item converter parameter. This is a dependency property.
        /// </summary>
        /// <returns>Returns item converter parameter.</returns>
        public object ItemConverterParameter
        {
            get
            {
                return this.GetValue(ItemConverterParameterProperty);
            }
            set
            {
                this.SetValue(ItemConverterParameterProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets selected time. This is a dependency property.
        /// </summary>
        /// <returns>Returns selected time.</returns>
        public TimeSpan SelectedTime
        {
            get
            {
                return (TimeSpan)this.GetValue(SelectedTimeProperty);
            }
            set
            {
                this.SetValue(SelectedTimeProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the time span items. This is a dependency property.
        /// </summary>
        /// <returns>Returns time span items.</returns>
        public IEnumerable<TimeSpan> TimeSpanItems
        {
            get
            {
                return (IEnumerable<TimeSpan>)this.GetValue(TimeSpanItemsProperty);
            }
            set
            {
                this.SetValue(TimeSpanItemsProperty, value);
            }
        }

        /// <summary>
        /// Search for template parts and initialize them.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            this.combo = this.GetTemplateChild(ComboBoxName) as RadComboBox;

            var window = this.GetParent<RadWindow>();

            if (this.combo != null && window != null)
            {

               StyleManager.SetThemeFromParent(this.combo, window);


                this.combo.ApplyTemplate();

                var textBox = this.combo.Template.FindName("PART_EditableTextBox", this.combo) as TextBox;

                if (textBox != null)
                {
                    textBox.LostFocus -= this.OnEditableTextBoxLostFocus; 
                    textBox.LostFocus += this.OnEditableTextBoxLostFocus;
                }
            }
            this.RebindCombo();
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the ItemConverter property.
        /// </summary>
        protected virtual void OnItemConverterChanged(DependencyPropertyChangedEventArgs args)
        {
            this.RebindCombo();
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the ItemConverterParameter property.
        /// </summary>
        protected virtual void OnItemConverterParameterChanged(DependencyPropertyChangedEventArgs args)
        {
            this.RebindCombo();
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the <see cref="SelectedTime"/> property.
        /// </summary>
        protected virtual void OnSelectedTimeChanged(DependencyPropertyChangedEventArgs args)
        {
            if (this.SelectedTimeChanged != null)
            {
                this.SelectedTimeChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the TimeSpanItems property.
        /// </summary>
        protected virtual void OnTimeSpanItemsChanged(DependencyPropertyChangedEventArgs args)
        {
            this.RebindCombo();
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
        /// Handles changes to the ItemConverter property.
        /// </summary>
        private static void OnItemConverterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((SchedulerTimePicker)d).OnItemConverterChanged(e);
        }

        /// <summary>
        /// Handles changes to the ItemConverterParameter property.
        /// </summary>
        private static void OnItemConverterParameterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((SchedulerTimePicker)d).OnItemConverterParameterChanged(e);
        }

        /// <summary>
        /// Handles changes to the <see cref="SelectedTime"/> property.
        /// </summary>
        private static void OnSelectedTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            ((SchedulerTimePicker)d).OnSelectedTimeChanged(args);
        }

        /// <summary>
        /// Handles changes to the TimeSpanItems property.
        /// </summary>
        private static void OnTimeSpanItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((SchedulerTimePicker)d).OnTimeSpanItemsChanged(e);
        }

        private IEnumerable<string> Convert(IEnumerable<TimeSpan> source)
        {
            if (source == null)
            {
                return null;
            }

            IList<string> list = new List<string>();
            foreach (TimeSpan span in source)
            {

                object value = this.ItemConverter.Convert(span, typeof(string), this.ItemConverterParameter, this.Language.GetEquivalentCulture());
                if (value != Binding.DoNothing)
                {
                    list.Add((string)value);
                }

            }

            return list;
        }

        private void OnEditableTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            this.RebindCombo();
        }

        private void RebindCombo()
        {
            if (this.combo == null)
            {
                return;
            }

            var binding = new Binding("SelectedTime");
            binding.Source = this;
            binding.Mode = BindingMode.TwoWay;
            binding.Converter = this.ItemConverter;
            binding.ConverterParameter = this.ItemConverterParameter;

            binding.ConverterCulture = this.Language.GetEquivalentCulture();

            this.combo.SetBinding(RadComboBox.TextProperty, binding);

            this.combo.ItemsSource = this.Convert(this.TimeSpanItems);
        }
    }
}
