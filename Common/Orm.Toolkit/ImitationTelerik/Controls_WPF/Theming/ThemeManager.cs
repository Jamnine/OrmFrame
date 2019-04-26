using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// This class supports the Telerik theming infrastructure and is not intended to be used directly from your code.
	/// </summary>
	public static class ThemeManager
	{
		internal static readonly string DefaultThemeName = "Office_Black";

		/// <summary>
		/// Contains all standard themes.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		public static readonly Dictionary<string, Theme> StandardThemes = new Dictionary<string, Theme>();

		/// <summary>
		/// Contains the names of all common themes - used for the QSF Theme dropdown and intellisense.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		public static readonly ReadOnlyCollection<string> StandardThemeNames;

		private static readonly List<string> standardThemeNames = new List<string>();

		/// <summary>
		/// Initializes static members of the ThemeManager class.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
		static ThemeManager()
		{
            RegisterTheme("Office_Black", new Office_BlackTheme(), true);
            //RegisterTheme("Office_Blue", new Office_BlueTheme(), true);
            //RegisterTheme("Office_Silver", new Office_SilverTheme(), true);
            //RegisterTheme("Summer", new SummerTheme(), true);
            //RegisterTheme("Vista", new VistaTheme(), true);
            //RegisterTheme("Windows7", new Windows7Theme(), true);
            //RegisterTheme("Transparent", new TransparentTheme(), true);

			StandardThemeNames = new ReadOnlyCollection<string>(standardThemeNames);
		}

		/// <summary>
		/// Returns a standard theme with the specified name. Fallbacks to the default theme 
		/// if a standard theme was not found.
		/// </summary>
		/// <param name="themeName">Name of the theme.</param>
		public static Theme FromName(string themeName)
		{
			if (themeName != null)
			{
				if (StandardThemes.ContainsKey(themeName))
				{
					return StandardThemes[themeName];
				}
				else
				{
					return StandardThemes[DefaultThemeName];
				}
			}
			return null;
		}

		private static void RegisterTheme(string name, Theme theme, bool isCommon)
		{
			StandardThemes.Add(name, theme);
			if (isCommon)
			{
				standardThemeNames.Add(name);
			}
		}
	}
}