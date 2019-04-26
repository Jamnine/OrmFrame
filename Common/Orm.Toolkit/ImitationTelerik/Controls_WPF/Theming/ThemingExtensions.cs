using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal static class ThemingExtensions
	{
		internal static void SetDefaultStyleKey<T>(this T itemsControl)
			where T : ItemsControl
		{
			var theme = StyleManager.GetTheme(itemsControl);

			itemsControl.ApplyThemeToItems();

			SetDefautStyleKeyFromTheme(itemsControl, theme);
		}

		private static void ApplyThemeToItems(this ItemsControl itemsControl)
		{
			Theme theme = StyleManager.GetTheme(itemsControl);

			for (int i = 0; i < itemsControl.Items.Count; i++)
			{
				var container = itemsControl.ItemContainerGenerator.ContainerFromIndex(i) as FrameworkElement;
				if (container != null)
				{
					container.SetTheme(theme);
				}
			}
		}

		private static void SetTheme(this FrameworkElement element, Theme theme)
		{
			if (!(element is IThemable))
			{
				SetDefautStyleKeyFromTheme(element, theme);
			}

			StyleManager.SetTheme(element, theme);
		}

		private static void SetDefautStyleKeyFromTheme<T>(this T element, Theme theme)
			where T : FrameworkElement
		{
			element.SetValue(DefaultStyleKeyHelper.FindDefaultStyleKey(),
			ThemeResourceKey.GetDefaultStyleKey(theme, typeof(T)));
		}

		private class DefaultStyleKeyHelper : FrameworkElement
		{
			public static DependencyProperty FindDefaultStyleKey()
			{
				return FrameworkElement.DefaultStyleKeyProperty;
			}
		}
	}
}
