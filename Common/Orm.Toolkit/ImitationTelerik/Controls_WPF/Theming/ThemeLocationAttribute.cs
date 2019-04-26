using System;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// The ThemeLocation attribute decorates a Theme class and carries information about where the theme is hosted.
	/// If a theme does not have that attribute, it is treated as an external theme by default.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false,  Inherited = false)]
	public sealed class ThemeLocationAttribute : Attribute
	{
		private ThemeLocation location;

		/// <summary>
		/// Initializes a new instance of the <see cref="ThemeLocationAttribute"/> class.
		/// </summary>
		/// <param name="location">The location.</param>
		public ThemeLocationAttribute(ThemeLocation location)
		{
			this.location = location;
		}

		/// <summary>
		/// Gets the theme location type.
		/// </summary>
		/// <value>The location.</value>
		public ThemeLocation Location
		{
			get 
			{
				return this.location;
			}
		}
	}
}