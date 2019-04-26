using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls.Calendar
{
	/// <summary>
	///     A panel that governs transitions from one of its children to another.
	/// </summary>
	public class TransitionPanel : Panel
	{


		/// <summary>
		///     Brings up the given element and hides or moves away the others.
		/// </summary>
		/// <param name="childToTransitionTo">The element ot bring up.</param>
		/// <remarks>
		///     The given element should be a child of the panel.
		/// </remarks>
		internal void TransitionTo(UIElement childToTransitionTo)
		{
			foreach (UIElement childElement in Children)
			{
				FrameworkElement child = childElement as FrameworkElement;

				if (child == childToTransitionTo)
				{
					child.Visibility = Visibility.Visible;
				}
				else
				{
					child.Visibility = Visibility.Collapsed;
				}
			}
		}

		internal void TransitionDownTo(UIElement childToTransitionTo)
		{
			foreach (UIElement childElement in Children)
			{
				FrameworkElement child = childElement as FrameworkElement;

				if (child == childToTransitionTo)
				{
					child.Visibility = Visibility.Visible;
					CalendarAnimation.ChangeScaleAndOpacity(child, 0.2, 1, 0, 1, TimeSpan.FromMilliseconds(300), null);
				}
				else
				{
					CalendarAnimation.ChangeScaleAndOpacity(child, 1, 2, 1, 0, TimeSpan.FromMilliseconds(300), new CalendarAnimation.ActionRequest<FrameworkElement>(o => o.Visibility = Visibility.Collapsed, child));
				}
			}
		}

		internal void TransitionUpTo(UIElement childToTransitionTo)
		{
			foreach (UIElement childElement in Children)
			{
				FrameworkElement child = childElement as FrameworkElement;

				if (child == childToTransitionTo)
				{
					child.Visibility = Visibility.Visible;
					CalendarAnimation.ChangeScaleAndOpacity(child, 2, 1, 0, 1, TimeSpan.FromMilliseconds(300), null);
				}
				else
				{
					CalendarAnimation.ChangeScaleAndOpacity(child, 1, 0.2, 1, 0, TimeSpan.FromMilliseconds(300), new CalendarAnimation.ActionRequest<FrameworkElement>(o => o.Visibility = Visibility.Collapsed, child));
				}
			}
		}

		/// <summary>
		/// When overridden in a derived class, measures the size in layout required for child elements and determines a size for the <see cref="T:System.Windows.FrameworkElement"/>-derived class.
		/// </summary>
		/// <param name="availableSize">The available size that this element can give to child elements. Infinity can be specified as a value to indicate that the element will size to whatever content is available.</param>
		/// <returns>
		/// The size that this element determines it needs during layout, based on its calculations of child element sizes.
		/// </returns>
		protected override Size MeasureOverride(Size availableSize)
		{
			double maxWidth = 0;
			double maxHEight = 0;
			foreach (UIElement child in Children)
			{
				child.Measure(availableSize);
				maxWidth = Math.Max(child.DesiredSize.Width, maxWidth);
				maxHEight = Math.Max(child.DesiredSize.Height, maxHEight);
			}
			return new Size(maxWidth, maxHEight);
		}

		/// <summary>
		/// When overridden in a derived class, positions child elements and determines a size for a <see cref="T:System.Windows.FrameworkElement"/> derived class.
		/// </summary>
		/// <param name="finalSize">The final area within the parent that this element should use to arrange itself and its children.</param>
		/// <returns>The actual size used.</returns>
		protected override Size ArrangeOverride(Size finalSize)
		{
			foreach (UIElement child in Children)
			{
				if (child.Visibility == Visibility.Visible)
				{
					FrameworkElement childElement = child as FrameworkElement;
					childElement.Arrange(new Rect(0, 0, finalSize.Width, finalSize.Height));
				}
			}
			return finalSize;
		}


	}
}