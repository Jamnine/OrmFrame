using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Extension methods for <see cref="ItemsControl"/> class.
    /// </summary>
    public static class ItemsControlExtensions
    {
        /// <summary>
        /// Gets the items panel from the visual tree of the control.
        /// </summary>
        /// <param name="itemsControl">The items control, which panel will be returned.</param>
        /// <returns>The <see cref="Panel"/> which will arrange the items.</returns>
        public static Panel GetItemsPanel(this ItemsControl itemsControl)
        {
            return GetItemsPanelRecursive(itemsControl);
        }

        private static Panel GetItemsPanelRecursive(DependencyObject control)
        {
            ////ensure template is applied

            var element = control as FrameworkElement;

            if (element != null)
            {
                element.ApplyTemplate();
            }

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(control); i++)
            {
                var child = VisualTreeHelper.GetChild(control, i) as UIElement;

                if (child != null)
                {
                    var panel = child as Panel;
                    if (panel != null && VisualTreeHelper.GetParent(child) is ItemsPresenter)
                    {
                        return panel;
                    }

                    panel = GetItemsPanelRecursive(child);

                    if (panel != null)
                    {
                        return panel;
                    }
                }
            }

            return null;
        }
    }
}