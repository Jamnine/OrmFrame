using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;

using System.Windows.Controls.Primitives;

using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Implements a selectable item inside a RadComboBox. 
	/// </summary>

	[DefaultProperty("IsSelected")]
	[DefaultEvent("Selected")]
	public class RadComboBoxItem : ListBoxItem
	{


		/// <summary>
		/// Identifies the IsHighlighted dependency property.
		/// </summary>
		private static readonly DependencyPropertyKey IsHighlightedPropertyKey =
			DependencyPropertyExtensions.RegisterReadOnly("IsHighlighted", typeof(bool), typeof(RadComboBoxItem), new PropertyMetadata(false, OnIsHighlightedChanged));



		private static readonly DependencyProperty IsHighlightedProperty = IsHighlightedPropertyKey.DependencyProperty;

		static RadComboBoxItem()
		{

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadComboBoxItem),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadComboBoxItem))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadComboBoxItem),
            new FrameworkPropertyMetadata(typeof(RadComboBoxItem)));

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RadComboBoxItem"/> class.
		/// </summary>
		public RadComboBoxItem()
		{

		}

		/// <summary>
		/// Gets a value that indicates whether the item is highlighted. This is a dependency property. 
		/// </summary>
		public bool IsHighlighted
		{
			get
			{
				return (bool)GetValue(IsHighlightedProperty);
			}
			protected set
			{
				this.SetValue(IsHighlightedPropertyKey, value);
			}
		}




		internal Selector ParentSelector
		{
			get
			{
				return ItemsControl.ItemsControlFromItemContainer(this) as Selector;
			}
		}


		private RadComboBox ParentComboBox
		{
			get
			{
				return this.ParentSelector as RadComboBox;
			}
		}


		internal void SetIsHighlighted(bool isHighlighted)
		{
			this.IsHighlighted = isHighlighted;
		}



		/// <summary>
		/// Called when the value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property changes.
		/// </summary>
		/// <param name="oldContent">The old value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property.</param>
		/// <param name="newContent">The new value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property.</param>
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			base.OnContentChanged(oldContent, newContent);
			RadComboBox combo = this.ParentComboBox;
			if (this.IsSelected && combo != null)
			{
				combo.SelectedItemUpdated();
			}
		}

		/// <summary>
		/// Called when the IsHighlighted property is changed.
		/// </summary>
		/// <param name="oldValue">The old value of the IsHighlighted property.</param>
		/// <param name="newValue">The new value of the IsHighlighted property.</param>
		protected virtual void OnIsHighlightedChanged(bool oldValue, bool newValue)
		{

		}

		/// <summary>
		/// Called when the user presses the left mouse button over the RadComboBoxItem.
		/// </summary>
		/// <param name="e">The event data.</param>
		protected override void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e)
		{
			e.Handled = true;

			RadComboBox parentComboBox = this.ParentComboBox;
			if (parentComboBox != null)
			{
				// parentComboBox.NotifyComboBoxItemMouseDown(this);
			}

			base.OnMouseLeftButtonDown(e);
		}


		/// <summary>
		/// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event. This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
		/// </summary>
		/// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(StyleManager.GetTheme(this), typeof(RadComboBoxItem));

            this.DefaultStyleKey =  typeof(RadComboBoxItem);
		}


		/// <summary>
		/// Called when the user releases the left mouse button over the ListBoxItem.
		/// </summary>
		/// <param name="e">The event data.</param>
		protected override void OnMouseLeftButtonUp(System.Windows.Input.MouseButtonEventArgs e)
		{
			e.Handled = true;

			RadComboBox parentComboBox = this.ParentComboBox;
			if (parentComboBox != null)
			{
				parentComboBox.NotifyComboBoxItemMouseUp(this);
			}

			base.OnMouseLeftButtonUp(e);
		}

		/// <summary>
		/// Responds to a MouseEnter event. 
		/// </summary>
		/// <param name="e">The MouseEventArgs instance containing the event data.</param>
		protected override void OnMouseEnter(System.Windows.Input.MouseEventArgs e)
		{
			RadComboBox parentComboBox = this.ParentComboBox;
			if (parentComboBox != null)
			{
				parentComboBox.NotifyComboBoxItemEnter(this);
			}

			base.OnMouseEnter(e);
		}




		/// <summary>
		/// Raises the <see cref="E:GotKeyboardFocus"/> event.
		/// </summary>
		/// <param name="e">The KeyboardFocusChangedEventArgs instance containing the event data.</param>
		protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			e.Handled = true;
			RadComboBox parentComboBox = this.ParentComboBox;
			if (parentComboBox != null)
			{
				parentComboBox.NotifyComboBoxItemEnter(this);
			}
			base.OnGotKeyboardFocus(e);
		}


		private static void OnIsHighlightedChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			(sender as RadComboBoxItem).OnIsHighlightedChanged((bool)e.OldValue, (bool)e.NewValue);
		}

	}
}