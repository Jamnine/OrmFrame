using System;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// This attribute marks Telerik controls that take advantage of 
	/// the Theme attached property.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class ThemableAttribute : Attribute
	{
	}
}