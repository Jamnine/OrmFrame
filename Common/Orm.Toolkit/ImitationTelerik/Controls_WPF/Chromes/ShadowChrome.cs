using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Orm.Toolkit.Telerik.Windows.Controls.Chromes
{
	/// <summary>
	/// Renders shadow image.
	/// </summary>
    public class ShadowChrome : Control
    {
		/// <summary>
		/// Initializes a new instance of the ShadowChrome class.
		/// </summary>
		public ShadowChrome()
        {

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
			Theme theme = StyleManager.GetTheme(this);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(theme, typeof(ShadowChrome));
		}

	}
}
