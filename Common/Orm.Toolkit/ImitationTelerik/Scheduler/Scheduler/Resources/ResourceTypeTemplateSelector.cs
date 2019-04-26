using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// A selector for the data template of resource type.
    /// </summary>
    public class ResourceTypeTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// Gets or sets the multiple selection template.
        /// </summary>
        /// <value>The multiple selection template.</value>
        public DataTemplate MultipleSelectionTemplate { get; set; }

        /// <summary>
        /// Gets or sets the single selection template.
        /// </summary>
        /// <value>The single selection template.</value>
        public DataTemplate SingleSelectionTemplate { get; set; }

        /// <summary>
        /// When overridden in a derived class, returns a <see cref="T:System.Windows.DataTemplate"/> based on custom logic.
        /// </summary>
        /// <param name="item">The data object for which to select the template.</param>
        /// <param name="container">The data-bound object.</param>
        /// <returns>
        /// Returns a <see cref="T:System.Windows.DataTemplate"/> or null. The default value is null.
        /// </returns>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            ResourceTypeViewModel model = item as ResourceTypeViewModel;
            if (model == null)
            {
                return base.SelectTemplate(item, container);
            }

            return model.ResourceType.AllowMultipleSelection ? this.MultipleSelectionTemplate : this.SingleSelectionTemplate;
        }
    } 
}
