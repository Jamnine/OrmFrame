
namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Specifies how TextSearch will match items.
	/// </summary>
	public enum TextSearchMode
	{
		/// <summary>
		/// Matches items, which text starts with the search text.
		/// </summary>
		StartsWith,

		/// <summary>
		/// Matches items, containing the search text.
		/// </summary>
		Contains,

		/// <summary>
		/// Matches items, which text starts with the search text. Case sensitive.
		/// </summary>
		StartsWithCaseSensitive,

		/// <summary>
		/// Matches items, containing the search text. Case sensitive.
		/// </summary>
		ContainsCaseSensitive
	}

	internal static class TextSearchModeExtensions
	{
		public static bool IsCaseSensitive(this TextSearchMode mode)
		{
			return mode == TextSearchMode.ContainsCaseSensitive || mode == TextSearchMode.StartsWithCaseSensitive;
		}

		public static bool IsStartsWith(this TextSearchMode mode)
		{
			return mode == TextSearchMode.StartsWith || mode == TextSearchMode.StartsWithCaseSensitive;
		}

		public static bool IsContains(this TextSearchMode mode)
		{
			return mode == TextSearchMode.Contains || mode == TextSearchMode.ContainsCaseSensitive;
		}
	}
}