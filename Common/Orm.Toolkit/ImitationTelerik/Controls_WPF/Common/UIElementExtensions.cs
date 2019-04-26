using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Contains helper extension methods for the UIElement class.
	/// </summary>
	public static class UIElementExtensions
	{
		/// <summary>
		/// Gets the parent element from the visual tree by given type.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
		public static T ParentOfType<T>(this UIElement element) where T : DependencyObject
		{
			if (element == null) return null;

			DependencyObject parent = VisualTreeHelper.GetParent(element);

			while ((parent != null) && !(parent is T))
			{
				DependencyObject newVisualParent = VisualTreeHelper.GetParent(parent);
				if (newVisualParent != null)
				{
					parent = newVisualParent;
				}
				else
				{
					// try to get the logical parent ( e.g. if in Popup)
					if (parent is FrameworkElement)
					{
						parent = (parent as FrameworkElement).Parent;
					}
					else
					{
						break;
					}
				}
			}

			return parent as T;
		}

		/// <summary>
		/// Gets all child elements recursively from the visual tree by given type.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
		public static IList<T> ChildrenOfType<T>(this UIElement element) where T : UIElement
		{
			List<T> list = new List<T>();

			if (element != null)
			{
				element.ChildrenOfType<T>(ref list);
			}

			return list;
		}

		private static IList<T> ChildrenOfType<T>(this UIElement element, ref List<T> list) where T : UIElement
		{
			int count = VisualTreeHelper.GetChildrenCount(element);

			for (int i = 0; i < count; i++)
			{
				DependencyObject child = VisualTreeHelper.GetChild(element, i);

				if (child is T)
				{
					list.Add((T)child);
				}

				var uiElementChild = child as UIElement;
				if (uiElementChild != null)
				{
					uiElementChild.ChildrenOfType<T>(ref list);
				}
			}

			return list;
		}

		internal static bool IsAncestorOf(this UIElement target, DependencyObject element)
		{
			if (target == element)
			{
				return true;
			}

			if (element == null)
			{
				throw new System.ArgumentNullException("element");
			}

			if (!(element is UIElement))
			{
				throw new InvalidOperationException("element is not UIElement");
			}

			DependencyObject parent = element;
			do
			{
				DependencyObject currentParent = VisualTreeHelper.GetParent(parent);
				var feParent = parent as FrameworkElement;
				if (currentParent == null && feParent != null)
				{
					parent = feParent.Parent;
				}
				else
				{
					parent = currentParent;
				}

				if (parent == target)
				{
					return true;
				}
			}
			while (parent != null);
			return false;
		}
	}
}
