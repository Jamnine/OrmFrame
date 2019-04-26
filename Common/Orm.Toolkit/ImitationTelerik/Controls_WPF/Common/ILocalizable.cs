namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// All elements with sophisticated localization machanizm have to implement this interface.
	/// </summary>
	public interface ILocalizable
	{
		/// <summary>
		/// A method to supply element with the localized data.
		/// </summary>
		/// <param name="localizedValue"></param>
		void SetString(string localizedValue);
	}
}
