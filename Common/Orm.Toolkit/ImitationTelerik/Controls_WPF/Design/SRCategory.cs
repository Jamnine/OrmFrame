using System;
using System.ComponentModel;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Specifies the name of the category in which to group the property or event in SR.
	/// </summary>
	[AttributeUsage(AttributeTargets.All)]
	public sealed class SRCategoryAttribute : CategoryAttribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SRCategoryAttribute"/> class.
		/// </summary>
		/// <param name="category">The name of the category.</param>
		public SRCategoryAttribute(string category) : base(category)
		{
		}

		/// <summary>
		/// Looks up the localized name of the specified category.
		/// </summary>
		/// <param name="value">The identifer for the category to look up.</param>
		/// <returns>
		/// The localized name of the category, or null if a localized name does not exist.
		/// </returns>
		protected override string GetLocalizedString(string value)
		{
			return SR.GetString(value);
		}
	}
}