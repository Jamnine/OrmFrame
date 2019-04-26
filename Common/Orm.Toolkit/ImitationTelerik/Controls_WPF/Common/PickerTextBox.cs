using System;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// A PickerTextBox class.
    /// </summary>
    public class PickerTextBox : TextBox, IThemable
    {

        static PickerTextBox()
		{
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(PickerTextBox),
            //        new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(PickerTextBox))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(PickerTextBox),
                    new FrameworkPropertyMetadata(typeof(PickerTextBox)));
		}


        /// <summary>
        /// Resets the theme.
        /// </summary>
        public void ResetTheme()
        {

            this.SetDefaultStyleKey();

        }

		/// <summary>
		/// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event. This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
		/// </summary>
		/// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
			this.SetDefaultStyleKey();
		}
		
		private void SetDefaultStyleKey()
        {
            //Theme theme = StyleManager.GetTheme(this);

            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(theme, typeof(PickerTextBox));

            this.DefaultStyleKey = typeof(PickerTextBox);
        }

    }
}