using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{   
    /// <summary>
    /// A control that contains all items representing resource group items.
    /// </summary>
    public class AppointmentsControlsContainer : ItemsControl
    {
        /// <summary>
        /// Identifies the <see cref="AttachedScrollBarProperty"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="AttachedScrollBarProperty"/> property.</returns>
        public static readonly DependencyProperty AttachedScrollBarProperty =
		DependencyProperty.Register("AttachedScrollBar", typeof(ScrollBar), typeof(AppointmentsControlsContainer), new PropertyMetadata(null));

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
        
        internal RadScheduler Scheduler
        {
            get
            {
                return this.GetParent<RadScheduler>();
            }
        }

        internal IEnumerable<AppointmentsControlsContainerItem> AppointmentsControlsContainerItems
        {
            get
            {
                foreach (object item in this.Items)
                {
                    yield return this.ItemContainerGenerator.ContainerFromItem(item) as AppointmentsControlsContainerItem;
                }
            }
        }

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes call <see cref="M:System.Windows.FrameworkElement.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (this.Scheduler != null)
            {
                this.ItemsSource = this.Scheduler.ResourceGroupsCollection;
            }
            
            if (this.Scheduler.ViewMode == SchedulerViewMode.Week || this.Scheduler.ViewMode == SchedulerViewMode.Day)
            {
                this.Loaded += (s, e) => { this.SetAttachedScrollBarState(); };
            }
        }

		internal void SetAttachedScrollBarState()
		{
            if (this.AttachedScrollBar != null)
            {
                if (this.Scheduler.AllDayAreaHeight == 0)
                {
                    this.AttachedScrollBar.Visibility = Visibility.Collapsed;
                    return;
                }
                else
                { 
                    this.AttachedScrollBar.Visibility = Visibility.Visible; 
                }

                foreach (var item in this.AppointmentsControlsContainerItems)
                {
                    if (item.AllDayScrollViewer.ViewportHeight < item.AllDayScrollViewer.ExtentHeight)
                    {
                        this.AttachedScrollBar.IsEnabled = true;
                        break;
                    }
                    else
                    {
                        this.AttachedScrollBar.IsEnabled = false;
                    }
                }
            }
		}

        /// <summary>
        /// Creates or identifies the element that is used to display the given item.
        /// </summary>
        /// <returns>
        /// The element that is used to display the given item.
        /// </returns>
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new AppointmentsControlsContainerItem();
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
            return item is AppointmentsControlsContainerItem;
        }

        /// <summary>
        /// When overridden in a derived class, undoes the effects of the <see cref="M:System.Windows.Controls.ItemsControl.PrepareContainerForItemOverride(System.Windows.DependencyObject,System.Object)"/> method.
        /// </summary>
        /// <param name="element">The container element.</param>
        /// <param name="item">The item.</param>
        protected override void ClearContainerForItemOverride(DependencyObject element, object item)
        {
            base.ClearContainerForItemOverride(element, item);
        }

        /// <summary>
        /// Prepares the specified element to display the specified item.
        /// </summary>
        /// <param name="element">Element used to display the specified item.</param>
        /// <param name="item">Specified item.</param>
        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            base.PrepareContainerForItemOverride(element, item);

            var appointmentsControlsContainerItem = element as AppointmentsControlsContainerItem;
            if (appointmentsControlsContainerItem == null)
            {
                return;
            }

            appointmentsControlsContainerItem.ResourceGroup = item as ResourceGroup;
            appointmentsControlsContainerItem.SetBinding(AppointmentsControlsContainerItem.AttachedScrollBarProperty,
														 new Binding("AttachedScrollBar") { Source = this, Mode = BindingMode.OneWay });
        }
    }
}
