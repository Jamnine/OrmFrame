using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Provides functionality for changing control themes.
	/// </summary>
	public static class StyleManager
	{

        /// <summary>
        /// Identifies the Theme attached property.
        /// </summary>
		public static readonly DependencyProperty ThemeProperty =
			DependencyProperty.RegisterAttached("Theme", typeof(Theme), typeof(StyleManager), new PropertyMetadata(OnThemeChanged));

		private static Theme applicationTheme;

        /// <summary>
        /// Specifies a Theme that will be automatically applied on all controls in the application. 
        /// </summary>
		public static Theme ApplicationTheme
		{
			get
			{
				return StyleManager.applicationTheme;
			}
			set
			{
				if (StyleManager.applicationTheme != value)
				{
					Theme oldValue = StyleManager.applicationTheme;

					StyleManager.applicationTheme = value;

				}
			}
		}

        /// <summary>
        /// Gets the theme of the specified <see cref="DependencyObject"/>.
        /// </summary>
        /// <param name="element">The element to get the theme of.</param>
        /// <returns></returns>
        [CategoryAttribute("Appearance")]
        [AttachedPropertyBrowsableWhenAttributePresent(typeof(ThemableAttribute))]
		public static Theme GetTheme(DependencyObject element)
		{
			return (Theme)element.GetValue(ThemeProperty);
		}

        /// <summary>
        /// Sets the theme of the specified <see cref="DependencyObject"/>.
        /// </summary>
        /// <param name="element">The element to set the theme of.</param>
        /// <param name="value">The new theme to set.</param>
		public static void SetTheme(DependencyObject element, Theme value)
		{
			element.SetValue(ThemeProperty, value);
		}

		/// <summary>
		/// Sets the theme of the specified <see cref="DependencyObject"/>.
		/// </summary>
		/// <param name="element">The element to set the theme of.</param>
		/// <param name="parent">Parent that supplies the theme.</param>
		public static void SetThemeFromParent(DependencyObject element, DependencyObject parent)
		{
			if (element == null || parent == null)
				return;

			StyleManager.SetTheme(element, StyleManager.GetTheme(parent));
		}

		private static void OnThemeChanged(DependencyObject target, DependencyPropertyChangedEventArgs changedEventArgs)
		{
			Theme newTheme = changedEventArgs.NewValue as Theme;

            IThemable themableControl = target as IThemable;
            if (themableControl != null)
            {
                themableControl.ResetTheme();
            }
            else
            {
                Control control = target as Control;
                if (control != null)
                {
                    Telerik.Windows.Controls.Theme.DefaultStyleKeyHelper.SetDefaultStyleKey(
                        control, ThemeResourceKey.GetDefaultStyleKey(newTheme, control.GetType()));
                }

            }
		}

	}
}