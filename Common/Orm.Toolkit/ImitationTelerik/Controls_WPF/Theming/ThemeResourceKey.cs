using System;
using System.Configuration;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// ThemeResourceKey class is used by the themming mechanism.
    /// Every visual control has a control template with different ThemeResourceKey for each theme.
    /// </summary>
    [MarkupExtensionReturnType(typeof(ThemeResourceKey))]
    public class ThemeResourceKey : ResourceKey
    {
        private Type themeType;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeResourceKey"/> class.
        /// </summary>
        public ThemeResourceKey()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeResourceKey"/> class.
        /// </summary>
        /// <param name="themeType">Type of the theme.</param>
        /// <param name="elementType">Type of the visual element.</param>
        public ThemeResourceKey(Type themeType, Type elementType)
        {
            this.themeType = themeType;
            this.ElementType = elementType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeResourceKey"/> class.
        /// </summary>
        /// <param name="themeType">Type of the theme.</param>
        /// <param name="elementType">Type of the visual element.</param>
        /// <param name="resourceId">The resource id.</param>
        public ThemeResourceKey(Type themeType, Type elementType, object resourceId)
        {
            this.themeType = themeType;
            this.ElementType = elementType;
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// Gets or sets the type of the theme.
        /// </summary>
        /// <value>The type of the theme.</value>
        public Type ThemeType
        {
            get
            {
                if (this.themeType == null)
                    this.themeType = PrepareThemeType(null);
                return this.themeType;
            }
            set
            {
                this.themeType = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the visual element.
        /// </summary>
        /// <value>The type of the visual element.</value>
        public Type ElementType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        /// <value>The resource id.</value>
        public object ResourceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets an assembly object that indicates which assembly's dictionary to look in for the value associated with this key.
        /// </summary>
        /// <value></value>
        /// <returns>The retrieved assembly, as a reflection class.</returns>
        public override Assembly Assembly
        {
            get
            {
                this.VerifyParameters();

                object[] themeTypeAttributes = this.ThemeType.GetCustomAttributes(typeof(ThemeLocationAttribute), false);
                ThemeLocation themeLocation = ThemeLocation.External;
                if (themeTypeAttributes.Length > 0)
                {
                    themeLocation = ((ThemeLocationAttribute)themeTypeAttributes[0]).Location;
                }

                if (themeLocation == ThemeLocation.External || IsSystemType(this.ElementType))
                {
                    return this.ThemeType.Assembly;
                }
                else
                {
                    return this.ElementType.Assembly;
                }
            }
        }

        internal static Theme DefaultSuiteTheme
        {
            get
            {
                return ThemeManager.StandardThemes[ThemeManager.DefaultThemeName];
            }
        }

        private static Theme ApplicationTheme
        {
            get
            {
                if (StyleManager.ApplicationTheme != null)
                {
                    return StyleManager.ApplicationTheme;
                }

                string appSettingsTheme = ConfigurationManager.AppSettings["Telerik.Theme"];
                if (!string.IsNullOrEmpty(appSettingsTheme))
                {
                    return (Theme)new ThemeConverter().ConvertFrom(null, CultureInfo.CurrentUICulture, appSettingsTheme);
                }
                else
                {
                    return DefaultSuiteTheme;
                }
            }
        }

        /// <summary>
        /// Gets the default style key.
        /// </summary>
        /// <param name="theme">The theme of the main control (control that implements IThemable interface).</param>
        /// <param name="elementType">Type of the visual element.</param>
        /// <returns></returns>
        public static ThemeResourceKey GetDefaultStyleKey(Theme theme, Type elementType)
        {
            return new ThemeResourceKey(PrepareThemeType(theme), elementType);
        }

        /// <summary>
        /// Gets the default style key.
        /// </summary>
        /// <param name="theme">The theme of the main control (control that implements IThemable interface).</param>
        /// <param name="elementType">Type of the visual element.</param>
        /// <param name="defaultTheme">The default theme.</param>
        /// <returns></returns>
        public static ThemeResourceKey GetDefaultStyleKey(Theme theme, Type elementType, Type defaultTheme)
        {
            return new ThemeResourceKey(theme == null ? defaultTheme : theme.GetType(), elementType);
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        public override int GetHashCode()
        {
            int resourceHashCode = this.ResourceId != null ? this.ResourceId.GetHashCode() : 0;

            if (this.ThemeType != null && this.ElementType != null)
            {
                return this.ThemeType.GetHashCode() ^ this.ElementType.GetHashCode() ^ resourceHashCode;
            }

            return resourceHashCode;
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.</param>
        /// <returns>
        /// True if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">The <paramref name="obj"/> parameter is null.</exception>
        public override bool Equals(object obj)
        {
            this.VerifyParameters();

            ThemeResourceKey key = obj as ThemeResourceKey;
            if (key == null)
            {
                return false;
            }
            else
            {
                return
                    (key.ThemeType == this.ThemeType) &&
                    (key.ElementType == this.ElementType) &&
                    object.Equals(key.ResourceId, this.ResourceId);
            }
        }

        private static bool IsSystemType(Type type)
        {
            return type.AssemblyQualifiedName.Contains("PresentationFramework");
        }

        private static Type PrepareThemeType(Theme theme)
        {
            Type themeType = null;
            if (theme == null)
            {
                themeType = ApplicationTheme.GetType();
            }
            else
            {
                themeType = theme.GetType();
            }
            return themeType;
        }

        private void VerifyParameters()
        {
            if (this.ThemeType == null || this.ElementType == null)
            {
                throw new ArgumentException("Must specify both theme and control type.");
            }
        }
    }
}