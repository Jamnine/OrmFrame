using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Time ruler control.
    /// </summary>
    public class TimeRuler : ItemsControl
    {
        /// <summary>
        /// Identifies the <see cref="TimeFormatString"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="TimeFormatString"/> property.</returns>
        public static readonly DependencyProperty TimeFormatStringProperty =
            DependencyProperty.Register("TimeFormatString", typeof(string), typeof(TimeRuler), new PropertyMetadata(OnTimeFormatStringChanged));

        private RadScheduler parentScheduler;


        /// <summary>
        /// Gets or sets time format string used by <see cref="TimeRuler"/> to show the time in different formats. This is a dependency property.
        /// </summary>
        /// <returns>The time format <see cref="string"/>. The default value is null.</returns>  
        public string TimeFormatString
        {
            get
            {
                return (string)this.GetValue(TimeFormatStringProperty);
            }
            set
            {
                this.SetValue(TimeFormatStringProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets TimeRulerItems. This is a dependency property.
        /// </summary>
        /// <returns>TimeRulerItems. The default value is null</returns>  
        public IEnumerable<TimeRulerItem> TimeRulerItems
        {
            get
            {
                foreach (TimeSlotGroup slotGroup in this.Items)
                {
                    yield return this.GetTimeRulerItemContainer(slotGroup);
                }
            }
        }

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application
        /// code or internal processes (such as a rebuilding layout pass) call
        /// <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {
            this.parentScheduler = this.GetParent<RadScheduler>();
				
            this.EnsureBinding();
	
			Binding bd = new Binding("TimeSlotsView.GroupedFirstGroupItems");
			bd.RelativeSource = RelativeSource.TemplatedParent;	
			this.SetBinding(TimeRuler.ItemsSourceProperty, bd);
            this.ConfigureTimeRulerStyle();

            base.OnApplyTemplate();
            this.SetDefaultsIfTimeFormatStringNotDefined();
        }


        /// <summary>
        /// Raises the <see cref="FrameworkElement.Initialized"/> event and sets <see cref="FrameworkElement.DefaultStyleKey" /> from the active theme.
        /// </summary>
        /// <param name="e">The <see cref="RoutedEventArgs"/> that contains the event data.</param>
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
           this.DefaultStyleKey = ControlExtensions.GetDefaultStyleKey(this);
        }

        /// <summary>
        /// Creates or identifies the element that is used to display the given item.
        /// </summary>
        /// <returns>
        /// The element that is used to display the given item.
        /// </returns>
        protected override DependencyObject GetContainerForItemOverride()
        {
            var timeRulerItem = new TimeRulerItem();

            return timeRulerItem;
        }

        /// <summary>
        /// Determines if the specified item is (or is eligible to be) its own container.
        /// </summary>
        /// <param name="item">The item to check.</param>
        /// <returns>
        /// True if the item is (or is eligible to be) its own container; otherwise, false.
        /// </returns>
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is TimeRulerItem;
        }

        /// <summary>
        /// Prepares the specified element to display the specified item.
        /// </summary>
        /// <param name="element">Element used to display the specified item.</param>
        /// <param name="item">Specified item.</param>
        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            base.PrepareContainerForItemOverride(element, item);

            var timeRulerItem = element as TimeRulerItem;
            if (timeRulerItem == null)
            {
                return;
            }
            var groupItem = item as TimeSlotGroup;
            if (groupItem != null)
            {
                var values = new object[] { this.TimeFormatString, groupItem.Start };
                timeRulerItem.TimeIndicator =Convert.ToDateTime(values[1].ToString()).ToString("HH:mm");
                //timeRulerItem.TimeIndicator =
                //    StringFormatConverter.Instance.Convert(values, typeof(string), null, CultureInfo.CurrentUICulture).ToString();
                timeRulerItem.TimeSlots = groupItem.TimeSlots;
            }
        }

        private static void OnTimeFormatStringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((TimeRuler)d).OnTimeFormatStringChanged();
        }

        private void EnsureBinding()
        {
            if (this.parentScheduler != null)
            {
                this.SetBinding(TimeFormatStringProperty, new Binding("TimeFormatString") { Source = this.parentScheduler, Mode = BindingMode.TwoWay });
            }
        }

        private void ConfigureTimeRulerStyle()
        {
            if (this.parentScheduler != null)
            {
                var timeRulerBorder = this.parentScheduler.GetChildByName("TimeRulerBorder");
                timeRulerBorder.Style = this.parentScheduler.TimeRulerHostStyle;
            }
        }
        private TimeRulerItem GetTimeRulerItemContainer(TimeSlotGroup group)
        {
            return this.ItemContainerGenerator.ContainerFromItem(group) as TimeRulerItem;
        }

        private void OnTimeFormatStringChanged()
        {
            this.SetDefaultsIfTimeFormatStringNotDefined();
        }

        private void SetDefaultsIfTimeFormatStringNotDefined()
        {
            if (string.IsNullOrEmpty(this.TimeFormatString))
            {
                var converter = new XmlLanguageToTimeFormatStringConverter();
                this.TimeFormatString = (string)converter.Convert(this.Language, typeof(string), null, CultureInfo.CurrentCulture);
            }
        }
    }
}
