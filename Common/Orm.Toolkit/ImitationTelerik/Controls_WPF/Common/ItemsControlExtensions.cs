using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Contains helper extension methods for the ItemsControl class.
	/// </summary>
	internal static class OriginalItemsControlExtensions
	{
		/// <summary>
		///     Executes the given action on each container item of the control.
		/// </summary>
		/// <typeparam name="T">The type of container expected, depends on the ItemControl calss.</typeparam>
		/// <param name="itemsControl">The ItemsControl instance.</param>
		/// <param name="work">The action to execute on the items.</param>
		internal static void ForEachContainerItem<T>(this ItemsControl itemsControl, Action<T> work) where T : class
		{
			for (int i = 0; i < itemsControl.Items.Count; i++)
			{
				T itemContainer = itemsControl.ItemContainerGenerator.ContainerFromIndex(i) as T;
				if (itemContainer != null)
				{
					work(itemContainer);
				}
			}
		}

		/// <summary>
		/// Enumerates the containers of a given ItemsControl.
		/// </summary>
		/// <typeparam name="T">The expected type of the containers.</typeparam>
		/// <param name="target">The target ItemsControl.</param>
		/// <returns>An enumerator for the containers of the items control.</returns>
		internal static IEnumerable<T> GetContainers<T>(this ItemsControl target) where T : class
		{
			for (int i = 0; i < target.Items.Count; i++)
			{
				var item = target.Items[i] as T;
				yield return item ?? target.ItemContainerGenerator.ContainerFromIndex(i) as T;
			}
		}

		/// <summary>
		/// Gets the items panel from the visual tree of the control.
		/// </summary>
		/// <param name="itemsControl">The items control, which panel will be returned.</param>
		/// <returns>The <see cref="Panel"/> which will arrange the items.</returns>
		internal static Panel GetItemsPanel(this DependencyObject itemsControl)
		{
            return GetItemsPanelRecursive(itemsControl);
		}

		internal static TPanel GetItemsPanel<TPanel>(this DependencyObject itemsControl) where TPanel : Panel
		{
			return GetItemsPanelRecursive<TPanel>(itemsControl);
		}

		private static Panel GetItemsPanelRecursive(DependencyObject control)
		{
			////ensure template is applied
			var element = control as Control;
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

		private static TPanel GetItemsPanelRecursive<TPanel>(DependencyObject control) where TPanel : Panel
		{
			////ensure template is applied
			var element = control as Control;
			if (element != null)
			{
				element.ApplyTemplate();
			}

			for (int i = 0; i < VisualTreeHelper.GetChildrenCount(control); i++)
			{
				var child = VisualTreeHelper.GetChild(control, i) as UIElement;

				if (child != null)
				{
					var panel = child as TPanel;
					if (panel != null && VisualTreeHelper.GetParent(child) is ItemsPresenter)
					{
						return panel;
					}

					panel = GetItemsPanelRecursive<TPanel>(child);

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