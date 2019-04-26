using System;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// This class represents extension methods and attached properties used by the DateTimePicker control.
    /// </summary>
    public static class DateTimePickerExtensions
    {        
		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.FocusOnOpen dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.FocusOnOpen dependency property.
		/// </returns>
		public static readonly DependencyProperty FocusContentOnOpenProperty =
			DependencyProperty.RegisterAttached("FocusContentOnOpen", typeof(bool), typeof(DateTimePickerExtensions), new PropertyMetadata(OnFocusContentOnOpenPropertyChanged));

        /// <summary>
		/// Gets a value that indicates whether the corresponding DropDownButton will auto-focus its content when opened.
        /// </summary>
        /// <param name="obj">The DropDownButton.</param>
		/// <returns>A value that indicates whether the corresponding DropDownButton will auto-focus its content when opened.</returns>
		public static bool GetFocusContentOnOpen(DependencyObject obj)
        {
			return (bool)obj.GetValue(FocusContentOnOpenProperty);
        }

        /// <summary>
        /// Sets a value that indicates whether the corresponding DropDownButton will auto-focus its content when opened.
        /// </summary>
        /// <param name="obj">The DropDownButton.</param>
		/// <param name="value">A value that indicates whether the corresponding DropDownButton will auto-focus its content when opened.</param>
		public static void SetFocusContentOnOpen(DependencyObject obj, bool value)
        {
			obj.SetValue(FocusContentOnOpenProperty, value);
        }

		private static void OnFocusContentOnOpenPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var button = d as RadDropDownButton;
			if (button != null)
			{
				var newValue = (bool)e.NewValue;

				if (newValue)
				{
					button.DropDownOpened += OnDropDownOpened;
				}
				else
				{
					button.DropDownOpened -= OnDropDownOpened;
				}
			}
		}

        private static void OnDropDownOpened(object sender, RoutedEventArgs args)
        {
            var button = sender as RadDropDownButton;
            var popup = button.DropDownPopup;

            if (popup.Child != null)
            {
                var control = popup.Child.FindChildByType<Control>();
                if (control != null)
                {
                    control.Dispatcher.BeginInvoke(new Action(() => control.Focus()));
                }
                else
                {
                    RoutedEventHandler handler = null;
                    handler = (s, e) =>
                    {
                        if (popup.Child != null)
                        {
                            control = popup.Child.FindChildByType<Control>();
                            if (control != null)
                            {
                                control.Focus();
                            }
                        }
                        popup.Loaded -= handler;
                    };
                    popup.Loaded += handler;
                }
            }
        }
    }
}
