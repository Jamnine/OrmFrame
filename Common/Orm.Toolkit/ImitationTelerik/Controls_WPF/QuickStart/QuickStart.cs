using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls.QuickStart
{
    /// <summary>
    /// Container for the ConfigurationPanel attached property used in QuickStart application.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
    public static class QuickStart
    {
        /// <summary>
        /// Gets the value of the ConfigurationPanel attached property from a given DependencyObject.
        /// </summary>
        /// <param name="obj">The DependencyObject from which to read the property value.</param>
        /// <returns>The value of the ConfigurationPanel attached property.</returns>
        public static Panel GetConfigurationPanel(DependencyObject obj)
        {
            return (Panel)obj.GetValue(ConfigurationPanelProperty);
        }

        /// <summary>
        /// Sets the value of the ConfigurationPanel attached property to a given DependencyObject.
        /// </summary>
        /// <param name="obj">The DependencyObject on which to set the property value.</param>
        /// <param name="value">The property value to set.</param>
        public static void SetConfigurationPanel(DependencyObject obj, Panel value)
        {
            obj.SetValue(ConfigurationPanelProperty, value);
        }

        /// <summary>
        /// Identifies the ConfigurationPanel attached property.
        /// </summary>
        private static readonly DependencyProperty ConfigurationPanelProperty =
            DependencyProperty.RegisterAttached("ConfigurationPanel", typeof(Panel), typeof(QuickStart), new PropertyMetadata(null));
    }
}
