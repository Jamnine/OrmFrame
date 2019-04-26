using System.Windows;
using System.Windows.Controls;
using System;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal static class ControlExtensions
	{
		public static void ResetTemplate(this Control control)
		{
			ControlTemplate cachedTemplate = control.Template;
			control.Template = null;
			control.Template = cachedTemplate;
		}

		public static Theme GetControlTheme(this Control control)
		{
			DependencyObject themeSource = control;
			Theme themeToApply = StyleManager.GetTheme(themeSource);

			while (themeSource != null && themeToApply == null)
			{
				themeSource = DependencyObjectExtensions.GetVisualParent<DependencyObject, IThemable>(themeSource);
				if (themeSource != null)
					themeToApply = StyleManager.GetTheme(themeSource);
			}

			return themeToApply;
		}

		public static object GetDefaultStyleKey(this Control control)
		{
            //Theme themeToApply = control.GetControlTheme();

            //return ThemeResourceKey.GetDefaultStyleKey(themeToApply, control.GetType());

            return control.GetType();
		}

        internal static object GetDefaultStyleKey(this Control control, Type controlType)
        {
            //Theme themeToApply = control.GetControlTheme();

            //return ThemeResourceKey.GetDefaultStyleKey(themeToApply, controlType);

            return control.GetType();
        }

		public static object GetDefaultStyleKey(this Control control, DependencyObject themableControl)
		{
            //if (themableControl != null)
            //{
            //    Theme themeToApply = GetControlTheme(themableControl as Control);
            //    return ThemeResourceKey.GetDefaultStyleKey(themeToApply, control.GetType());
            //}

            return GetDefaultStyleKey(control);
		}


	}
}
