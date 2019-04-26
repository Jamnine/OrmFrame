using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Contains the location of the Theme.
	/// </summary>
	[TypeConverter(typeof(ThemeConverter))]
	public class Theme
	{


		/// <summary>
		/// Initializes a new instance of the <see cref="Theme"/> class.
		/// </summary>
		public Theme()
		{
		}


		/// <summary>
		/// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
		/// </returns>
		public override string ToString()
		{
			return GetType().Name.Replace("Theme", string.Empty);
		}


		internal class DefaultStyleKeyHelper : Control
		{
			public static void SetDefaultStyleKey(Control control, object value)
			{
				control.SetValue(DefaultStyleKeyProperty, value);
			}
		}
	}
}