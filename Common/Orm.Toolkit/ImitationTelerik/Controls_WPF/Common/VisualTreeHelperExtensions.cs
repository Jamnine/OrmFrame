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
using System.Linq;
using System.Windows.Controls.Primitives;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal static class VisualTreeHelperExtensions
	{
		/// <summary>  
		/// This recurses the visual tree for a parent of a specific type.
		/// </summary>  
		/// <param name="child"></param>  
		internal static T GetParent<T>(this DependencyObject child) where T : FrameworkElement
		{
            return UIElementExtensions.ParentOfType<T>(child as UIElement);
		}

		/// <summary>  
		/// This recurses the visual tree for ancestors of a specific type.
		/// </summary>  
		/// <param name="target">The element to get ancestor of.</param>
		internal static IEnumerable<T> GetAncestors<T>(this DependencyObject target) where T : class
		{
			DependencyObject parent = target;
			while (parent != null)
			{
				parent = VisualTreeHelper.GetParent(parent);
				if (parent != null)
				{
					if (parent is T)
					{
						yield return parent as T;
					}
				}
			}
			yield break;
		}

		/// <summary>
		/// This recurses the visual tree for children of a specific type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="parent"></param>
		/// <returns></returns>
		internal static List<T> GetChildren<T>(this DependencyObject parent) where T : FrameworkElement
		{
			List<T> collection = new List<T>();

			DependencyObject child = parent;

			if (child != null)
			{
				int count = VisualTreeHelper.GetChildrenCount(parent);
				for (int i = 0; i < count; i++)
				{
					DependencyObject obj = VisualTreeHelper.GetChild(parent, i);
					if (obj.GetType() == typeof(T))
					{
						collection.Add((T)obj);
					}
					if (VisualTreeHelper.GetChildrenCount(obj) > 0)
					{
						foreach (T newElement in VisualTreeHelperExtensions.GetChildren<T>(obj))
						{
							collection.Add(newElement);
						}
					}
				}
			}
			else
			{
				return null;
			}
			return collection;
		}

		internal static IEnumerable<T> GetElementsInHostCoordinates<T>(this UIElement subtree, Point position)  where T : UIElement
		{
			if (subtree == null)
			{
				return Enumerable.Empty<T>();
			}

			var elements = new List<T>(50);
			UIElement root = ApplicationHelper.GetRootVisual(subtree);

			VisualTreeHelper.HitTest(subtree,
				null,
				r =>
				{
					UIElement e = r.VisualHit as UIElement;
					var localElements = new List<UIElement>(50);
					while (e != null)
					{
						if (e.Visibility == Visibility.Visible)
						{
							localElements.Add(e);
						}
						else
						{
							localElements.Clear();
						}

						e = VisualTreeHelper.GetParent(e) as UIElement;
					}
					elements.AddRange(localElements.OfType<T>());
					return HitTestResultBehavior.Continue;
				},
				new PointHitTestParameters(position));

			return elements;
		}

		internal static IEnumerable<T> GetElementsInScreenCoordinates<T>(this FrameworkElement relativeTo, Point mousePosition) where T : UIElement
		{
			return GetElementsInScreenCoordinates<T>(mousePosition, ApplicationHelper.GetRootVisual(relativeTo));
		}

		internal static IEnumerable<T> GetElementsInScreenCoordinates<T>(Point mousePosition) where T : UIElement
		{
			return GetElementsInScreenCoordinates<T>(mousePosition, ApplicationHelper.RootVisual);
		}

		internal static IEnumerable<T> GetElementsInScreenCoordinatesFromOpenedPopups<T>(Point position) where T : UIElement
		{
			var popups = Enumerable.Empty<Popup>();

			// TODO: Find all the popups in WPF.

			// NOTE: This way we will get even elements that are not visible (are under some popups). Should think about that!

			// Miro N. - Change: Remove the Take(1) from the Linq - no reason to take only the first Popup.
			return popups.SelectMany(p => p.Child.GetElementsInHostCoordinates<T>(position));
		}

		private static IEnumerable<T> GetElementsInScreenCoordinates<T>(Point mousePosition, FrameworkElement rootVisual) where T : UIElement
		{
			return GetElementsInScreenCoordinatesFromOpenedPopups<T>(mousePosition).Concat(rootVisual.GetElementsInHostCoordinates<T>(mousePosition));
		}
	}
}