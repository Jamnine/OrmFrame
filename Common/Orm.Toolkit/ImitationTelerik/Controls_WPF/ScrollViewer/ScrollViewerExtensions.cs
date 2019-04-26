using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Contains attached behavior for enabling mouse wheel scrolling for ScrollViewer controls.
	/// </summary>
	public static class ScrollViewerExtensions
	{

		
		private static void OnHorizontalOffsetChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
			System.Diagnostics.Debug.WriteLine("OnHorizontalOffsetChanged: " + (double)args.NewValue + " " + obj);
			((ScrollViewer)obj).ScrollToHorizontalOffset((double)args.NewValue);
		}

		private static void OnVerticalOffsetChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
			System.Diagnostics.Debug.WriteLine("OnVerticalOffsetChanged: " + (double)args.NewValue + " " + obj);
			((ScrollViewer)obj).ScrollToVerticalOffset((double)args.NewValue);
		}

		private static void OnAttachedVerticalScrollBarPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var scrollViewer = d as ScrollViewer;
			var scrollBar = e.NewValue as ScrollBar;
			if (scrollBar != null)
			{
				scrollBar.ValueChanged += (s, args) =>
				{
					scrollViewer.ScrollToVerticalOffset(args.NewValue);
				};
			}
			scrollViewer.ApplyTemplate();

			var internalScrollBar = ((FrameworkElement)VisualTreeHelper.GetChild(scrollViewer, 0)).FindName("PART_VerticalScrollBar") as ScrollBar;

			internalScrollBar.ValueChanged += (s, args) =>
			{
				if (scrollBar != null)
				{
					scrollBar.Value = args.NewValue;
				}
			};
		}

		/// <summary>
		/// DependencyProperty identifying the AttachedVerticalScrollBar attached property.
		/// </summary>
		public static readonly DependencyProperty AttachedVerticalScrollBarProperty =
			DependencyProperty.RegisterAttached("AttachedVerticalScrollBar", typeof(ScrollBar), typeof(ScrollViewerExtensions), new PropertyMetadata(null, OnAttachedVerticalScrollBarPropertyChanged));

		/// <summary>
		/// DependencyProperty identifying the AttachedHorizontalScrollBar attached property.
		/// </summary>
		public static readonly DependencyProperty AttachedHorizontalScrollBarProperty =
			DependencyProperty.RegisterAttached("AttachedHorizontalScrollBar", typeof(ScrollBar), typeof(ScrollViewerExtensions), new PropertyMetadata(null, OnAttachedHorizontalScrollBarPropertyChanged));

		/// <summary>
		/// Sets the attached external Vertical ScrollBar to a ScrollViewer.
		/// </summary>
		/// <param name="obj">The ScrollViewer.</param>
		/// <returns>The ScrollBar instance.</returns>
		public static ScrollBar GetAttachedVerticalScrollBar(DependencyObject obj)
		{
			return (ScrollBar)obj.GetValue(AttachedVerticalScrollBarProperty);
		}

		/// <summary>
		/// Gets the attached external Vertical ScrollBar to a ScrollViewer.
		/// </summary>
		/// <param name="obj">The ScrollViewer.</param>
		/// <param name="value">The ScrollBar instance.</param>
		public static void SetAttachedVerticalScrollBar(DependencyObject obj, ScrollBar value)
		{
			obj.SetValue(AttachedVerticalScrollBarProperty, value);
		}

		/// <summary>
		/// Sets the attached external Horizontal ScrollBar to a ScrollViewer.
		/// </summary>
		/// <param name="obj">The ScrollViewer.</param>
		/// <returns>The ScrollBar instance.</returns>
		public static ScrollBar GetAttachedHorizontalScrollBar(DependencyObject obj)
		{
			return (ScrollBar)obj.GetValue(AttachedHorizontalScrollBarProperty);
		}

		/// <summary>
		/// Gets the attached external Horizontal ScrollBar to a ScrollViewer.
		/// </summary>
		/// <param name="obj">The ScrollViewer.</param>
		/// <param name="value">The ScrollBar instance.</param>
		public static void SetAttachedHorizontalScrollBar(DependencyObject obj, ScrollBar value)
		{
			obj.SetValue(AttachedHorizontalScrollBarProperty, value);
		}

		private static void OnAttachedHorizontalScrollBarPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var scrollViewer = d as ScrollViewer;
			var scrollBar = e.NewValue as ScrollBar;
			if (scrollBar != null)
			{
				scrollBar.ValueChanged += (s, args) =>
				{
					scrollViewer.ScrollToHorizontalOffset(args.NewValue);
				};
			}
			scrollViewer.ApplyTemplate();

			var internalScrollBar = ((FrameworkElement)VisualTreeHelper.GetChild(scrollViewer, 0)).FindName("PART_HorizontalScrollBar") as ScrollBar;

			internalScrollBar.ValueChanged += (s, args) =>
			{
				scrollBar.Value = args.NewValue;
			};
		}






	}
}