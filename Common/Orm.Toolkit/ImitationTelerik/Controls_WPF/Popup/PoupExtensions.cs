using System;
using System.Windows;
using System.Windows.Controls.Primitives;


using NativePlacementMode = System.Windows.Controls.Primitives.PlacementMode;


namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// This class contains attached properties for the Popup class. These properties are meant to be used to fill the gaps between
	/// the WPF Popup class and the Silverlight one.
	/// </summary>
	public static class PopupExtensions
	{
		/// <summary>
		/// Indentifies the IsOpen attached property.
		/// </summary>
		public static readonly DependencyProperty IsOpenProperty =
			DependencyProperty.RegisterAttached("IsOpen", typeof(bool), typeof(PopupExtensions), new PropertyMetadata(OnIsOpenChanged));

		/// <summary>
		/// Indentifies the StaysOpen attached property.
		/// </summary>
		public static readonly DependencyProperty StaysOpenProperty =
			DependencyProperty.RegisterAttached("StaysOpen", typeof(bool), typeof(PopupExtensions), new PropertyMetadata(OnStaysOpenChanged));

		/// <summary>
		/// Indentifies the PlacementRectangle attached property.
		/// </summary>
		public static readonly DependencyProperty PlacementRectangleProperty =
			DependencyProperty.RegisterAttached("PlacementRectangle", typeof(Rect), typeof(PopupExtensions), new PropertyMetadata(Rect.Empty, OnPlacementRectangleChanged));

		/// <summary>
		/// Indentifies the Placement attached property.
		/// </summary>
		public static readonly DependencyProperty PlacementProperty =
			DependencyProperty.RegisterAttached("Placement", typeof(NativePlacementMode), typeof(PopupExtensions), new PropertyMetadata(OnPlacementChanged));

		/// <summary>
		/// Indentifies the PlacementTarget attached property.
		/// </summary>
		public static readonly DependencyProperty PlacementTargetProperty =
			DependencyProperty.RegisterAttached("PlacementTarget", typeof(UIElement), typeof(PopupExtensions), new PropertyMetadata(OnPlacementTargetChanged));

		/// <summary>
		/// Indentifies the Owner attached property. This property is used to determine the Owner of the popup - the element that will be clickable when
		/// the StaysOpen attached property is set to false.
		/// </summary>
		public static readonly DependencyProperty OwnerProperty =
			DependencyProperty.RegisterAttached("Owner", typeof(FrameworkElement), typeof(PopupExtensions), new PropertyMetadata(OnOwnerChanged));


		/// <summary>
		/// Gets a value indicating whether the Popup is open or not.
		/// </summary>
		/// <param name="obj">The corresponding popup.</param>
		/// <returns>A value indicating whether the Popup is open or not.</returns>
		public static bool GetIsOpen(DependencyObject obj)
		{
			return (bool)obj.GetValue(IsOpenProperty);
		}

		/// <summary>
		/// Sets a value indicating whether the Popup is open or not.
		/// </summary>
		/// <param name="obj">The corresponding popup.</param>
		/// <param name="value">A value indicating whether the Popup is open or not.</param>
		public static void SetIsOpen(DependencyObject obj, bool value)
		{
			obj.SetValue(IsOpenProperty, value);
		}

		/// <summary>
		/// Gets a value indicating whether the Popup stays open when clicking outside or not.
		/// </summary>
		/// <param name="obj">The corresponding popup.</param>
		/// <returns>A value indicating whether the Popup stays open when clicking outside or not.</returns>
		public static bool GetStaysOpen(DependencyObject obj)
		{
			return (bool)obj.GetValue(StaysOpenProperty);
		}

		/// <summary>
		/// Sets a value indicating whether the Popup stays open when clicking outside or not.
		/// </summary>
		/// <param name="obj">The corresponding popup.</param>
		/// <param name="value">A value indicating whether the Popup stays open when clicking outside or not.</param>
		public static void SetStaysOpen(DependencyObject obj, bool value)
		{
			obj.SetValue(StaysOpenProperty, value);
		}

		/// <summary>
		/// Gets a value describing the PlacementMode of the Popup.
		/// </summary>
		/// <param name="obj">The corresponding popup.</param>
		/// <returns>A value describing the PlacementMode of the Popup.</returns>
		public static NativePlacementMode GetPlacement(DependencyObject obj)
		{
			return (NativePlacementMode)obj.GetValue(PlacementProperty);
		}

		/// <summary>
		/// Sets a value describing the PlacementMode of the Popup.
		/// </summary>
		/// <param name="obj">The corresponding popup.</param>
		/// <param name="value">A value describing the PlacementMode of the Popup.</param>
		public static void SetPlacement(DependencyObject obj, NativePlacementMode value)
		{
			obj.SetValue(PlacementProperty, value);
		}

		/// <summary>
		/// Gets the rectangle relative to which the System.Windows.Controls.Primitives.Popup control is positioned when it opens.
		/// </summary>
		/// <param name="obj">The corresponding popup.</param>
		/// <returns>The rectangle relative to which the System.Windows.Controls.Primitives.Popup control is positioned when it opens.</returns>
		public static Rect GetPlacementRectangle(DependencyObject obj)
		{
			return (Rect)obj.GetValue(PlacementRectangleProperty);
		}

		/// <summary>
		/// Sets the rectangle relative to which the System.Windows.Controls.Primitives.Popup control is positioned when it opens.
		/// </summary>
		/// <param name="obj">The corresponding popup.</param>
		/// <param name="value">The rectangle relative to which the System.Windows.Controls.Primitives.Popup control is positioned when it opens.</param>
		public static void SetPlacementRectangle(DependencyObject obj, Rect value)
		{
			obj.SetValue(PlacementRectangleProperty, value);
		}

		/// <summary>
		/// Gets the element relative to which the System.Windows.Controls.Primitives.Popup is positioned when it opens.
		/// </summary>
		/// <param name="obj">The corresponding popup.</param>
		/// <returns>The element relative to which the System.Windows.Controls.Primitives.Popup is positioned when it opens.</returns>
		public static UIElement GetPlacementTarget(DependencyObject obj)
		{
			return (UIElement)obj.GetValue(PlacementTargetProperty);
		}

		/// <summary>
		/// Sets the element relative to which the System.Windows.Controls.Primitives.Popup is positioned when it opens.
		/// </summary>
		/// <param name="obj">The corresponding popup.</param>
		/// <param name="value">The element relative to which the System.Windows.Controls.Primitives.Popup is positioned when it opens.</param>
		public static void SetPlacementTarget(DependencyObject obj, UIElement value)
		{
			obj.SetValue(PlacementTargetProperty, value);
		}

		/// <summary>
		/// Gets the owner of the Popup.
		/// </summary>
		/// <param name="obj">The corresponding popup.</param>
		/// <returns>The owner of the Popup.</returns>
		public static FrameworkElement GetOwner(DependencyObject obj)
		{
			return (FrameworkElement)obj.GetValue(OwnerProperty);
		}

		/// <summary>
		/// Sets the owner of the Popup.
		/// </summary>
		/// <param name="obj">The corresponding popup.</param>
		/// <param name="value">The owner of the Popup.</param>
		public static void SetOwner(DependencyObject obj, UIElement value)
		{
			obj.SetValue(OwnerProperty, value);
		}



		private static void ShowHidePopup(Popup popup, bool isShow)
		{
			popup.IsOpen = isShow;
		}

		private static void SetValue(Popup popup, DependencyProperty property, object value)
		{
			if (popup != null)
			{
				popup.SetValue(property, value);
			}
		}

		private static void OnStaysOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			SetValue(d as Popup, Popup.StaysOpenProperty, e.NewValue);
		}

		private static void OnPlacementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			SetValue(d as Popup, Popup.PlacementProperty, e.NewValue);
		}

		private static void OnPlacementRectangleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			SetValue(d as Popup, Popup.PlacementRectangleProperty, e.NewValue);		
		}

		private static void OnPlacementTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			SetValue(d as Popup, Popup.PlacementTargetProperty, e.NewValue);
		}

		private static void OnOwnerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
		}


		private static void OnIsOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var popup = d as Popup;
			if (popup != null)
			{
				ShowHidePopup(popup, (bool)e.NewValue);
			}
		}
	}
}
