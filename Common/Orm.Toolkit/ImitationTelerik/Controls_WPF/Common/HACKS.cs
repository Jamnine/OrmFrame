using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal static class HACKS
	{

		/// <summary>
		/// Removes a framework element from the VisualTree.
		/// </summary>
		/// <param name="child">The element to remove.</param>
		/// <returns>true if successful; false if not.</returns>
		internal static bool RemoveParent(FrameworkElement child)
		{
			return child.Parent != null &&
					(RemoveParent(child, child.Parent as Popup) ||
					RemoveParent(child, child.Parent as Border) ||
					RemoveParent(child, child.Parent as ContentControl) ||
					RemoveParent(child, child.Parent as ContentPresenter) ||
					RemoveParent(child, child.Parent as Panel));
		}		

		private static bool RemoveParent(FrameworkElement child, Panel parent)
		{
			if (parent != null && parent.Children.Contains(child))
			{
				parent.Children.Remove(child);
				return true;
			}

			return false;
		}

		private static bool RemoveParent(FrameworkElement child, ContentPresenter parent)
		{
			if (parent != null && parent.Content == child)
			{
				parent.ClearValue(ContentPresenter.ContentProperty);
				return true;
			}

			return false;
		}

		private static bool RemoveParent(FrameworkElement child, ContentControl parent)
		{
			if (parent != null && parent.Content == child)
			{
				parent.ClearValue(ContentControl.ContentProperty);
				return true;
			}

			return false;
		}

		private static bool RemoveParent(FrameworkElement child, Border parent)
		{
			if (parent != null && parent.Child == child)
			{
				parent.Child = null;
				return true;
			}

			return false;
		}

		private static bool RemoveParent(FrameworkElement child, Popup parent)
		{
			if (parent != null && parent.Child == child)
			{
				parent.ClearValue(Popup.ChildProperty);
				return true;
			}

			return false;
		}
	}
}