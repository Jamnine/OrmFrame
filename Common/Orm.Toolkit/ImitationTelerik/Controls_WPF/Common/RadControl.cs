using System;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Static container for the Theme attached property.
    /// </summary>
    public static class RadControl
    {
        /// <summary>
        /// Identifies the Theme attached property.
        /// </summary>
        //[Obsolete("This property will be removed in the next release. Please use StyleManager.ThemeProperty instead", true)]
        //public static readonly DependencyProperty ThemeProperty =
        //    DependencyProperty.RegisterAttached("Theme",
        //    typeof(Theme),
        //    typeof(RadControl),
        //    new PropertyMetadata(null, OnThemeChanged));

        private static bool? isInDesignMode = null;

        //internal static void InitIsInDesignMode(DependencyObject element)
        //{
        //    RadControl.IsInDesignMode = System.ComponentModel.DesignerProperties.GetIsInDesignMode(element);
        //}

        /// <summary>
        /// Gets whether a control is hosted within element host.
        /// </summary>
        /// <param name="element"></param>
        /// <returns><c>True</c> if the element is in element host; otherwise, <c>False</c>.</returns>
        internal static bool IsInElementHost(DependencyObject element)
        {
            return !System.ComponentModel.DesignerProperties.GetIsInDesignMode(element) &&
                (!System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted &&
                System.Windows.Interop.HwndSource.FromVisual(element as System.Windows.Media.Visual) != null);
        }


        /// <summary>
        /// Gets whether a control is running in the context of a designer.
        /// </summary>
        /// <value>
        /// 	<c>True</c> if this instance is in design mode; otherwise, <c>False</c>.
        /// </value>
        public static bool IsInDesignMode
        {
            get
            {
                if (isInDesignMode.HasValue)
                {
                    return isInDesignMode.Value;
                }

                RadControl.isInDesignMode = System.ComponentModel.DesignerProperties.GetIsInDesignMode(new ContentControl());
                return RadControl.isInDesignMode.Value;

            }
            internal set
            {
                isInDesignMode = value;
            }
        }

        ///// <summary>
        ///// Gets the value of the Theme attached property from a given DependencyObject.
        ///// </summary>
        ///// <param name="obj">The DependencyObject from which to read the property value.</param>
        ///// <returns>The value of the Theme attached property.</returns>
        //[Obsolete("This mthod will be removed in the next release. Please use StyleManager.GetTheme instead", true)]
        //public static Theme GetTheme(DependencyObject obj)
        //{
        //    if (obj == null)
        //    {
        //        throw new ArgumentNullException("obj");
        //    }
        //    return (Theme)obj.GetValue(ThemeProperty);
        //}

        ///// <summary>
        ///// Sets the value of the Theme attached property to a given DependencyObject.
        ///// </summary>
        ///// <param name="obj">The DependencyObject on which to set the property value.</param>
        ///// <param name="value">The property value to set.</param>
        //[Obsolete("This mthod will be removed in the next release. Please use StyleManager.SetTheme instead", true)]
        //public static void SetTheme(DependencyObject obj, Theme value)
        //{
        //    obj.SetValue(ThemeProperty, value);
        //}

        //private static void OnThemeChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        //{
        //    StyleManager.SetTheme(sender, e.NewValue as Theme);
        //}
    }
}