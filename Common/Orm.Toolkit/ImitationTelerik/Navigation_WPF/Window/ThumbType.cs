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

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal enum ThumbType
	{
		/// <summary>
		/// None of the thumbs.
		/// </summary>
		NONE = -1,

		/// <summary>
		/// West thumb.
		/// </summary>
		ElementWestThumb = 0,

		/// <summary>
		/// North-west thumb.
		/// </summary>
		ElementNorthWestThumb,

		/// <summary>
		/// North thumb.
		/// </summary>
		ElementNorthThumb,

		/// <summary>
		/// North-east thumb.
		/// </summary>
		ElementNorthEastThumb,

		/// <summary>
		/// East thumb.
		/// </summary>
		ElementEastThumb,

		/// <summary>
		/// South-east thumb.
		/// </summary>
		ElementSouthEastThumb,

		/// <summary>
		/// South thumb.
		/// </summary>
		ElementSouthThumb,

		/// <summary>
		/// South-west thumb.
		/// </summary>
		ElementSouthWestThumb,

		/// <summary>
		/// Title thumb.
		/// </summary>
		TitleThumb
	}
}
