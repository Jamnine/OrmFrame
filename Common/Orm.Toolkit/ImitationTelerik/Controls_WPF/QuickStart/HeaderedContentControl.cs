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

namespace Orm.Toolkit.Telerik.Windows.Controls.QuickStart
{
	/// <summary>
	/// A HeaderedContentControl control.
	/// </summary>
	public class HeaderedContentControl : System.Windows.Controls.HeaderedContentControl

	{


		static HeaderedContentControl()
		{
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(Telerik.Windows.Controls.QuickStart.HeaderedContentControl),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(Telerik.Windows.Controls.QuickStart.HeaderedContentControl))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(HeaderedContentControl), new FrameworkPropertyMetadata(typeof(HeaderedContentControl)));

		}


		/// <summary>
		/// Initializes a new instance of the RadButton class.
		/// </summary>
		public HeaderedContentControl()
		{

		}
	}
}
