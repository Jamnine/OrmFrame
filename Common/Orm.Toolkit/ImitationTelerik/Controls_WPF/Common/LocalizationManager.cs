using System;
using System.Globalization;
using System.Resources;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using Orm.Toolkit.ImitationTelerik;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// A localization manager class.
	/// </summary>
	public class LocalizationManager
	{
		/// <summary>
		/// Identifies the ResourceKey attached property.
		/// </summary>
		public static readonly DependencyProperty ResourceKeyProperty =
			DependencyProperty.RegisterAttached("ResourceKey",
				typeof(string),
				typeof(LocalizationManager),
				new PropertyMetadata(null, OnResourceKeyChanged));

		private static ResourceManager defaultResourceManager = Strings.ResourceManager;

		/// <summary>
		/// Holder of the only posibble Localization Manager.
		/// </summary>
		public static LocalizationManager Manager
		{
			get;
			set;
		}

		/// <summary>
		/// Default culture to follow if the specific one is null.
		/// This is an easy way to override the culture without instantiating a new manager.
		/// </summary>
		public static CultureInfo DefaultCulture
		{
			get;
			set;
		}

		/// <summary>
		/// Default resource manager to follow if the specific one is null.
		/// This is an easy way to override the resource manager without instantiating a new manager.
		/// </summary>
		public static ResourceManager DefaultResourceManager
		{
			get
			{
				return defaultResourceManager;
			}
			set
			{
				defaultResourceManager = value;
			}
		}

		/// <summary>
		/// Gets or sets specific resource manager.
		/// </summary>
		public ResourceManager ResourceManager
		{
			get;
			set;
		}

		/// <summary>
		/// A specific culture to follow.
		/// </summary>
		public CultureInfo Culture
		{
			get;
			set;
		}

		/// <summary>
		/// Returns a string related to the specified key.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <returns></returns>
		public static string GetString(string key)
		{
			LocalizationManager localizationManager = LocalizationManager.Manager;
			if (localizationManager != null)
			{
				return localizationManager.GetStringOverride(key);
			}
			return LocalizationManager.GetString(key,
				LocalizationManager.DefaultCulture,
				LocalizationManager.DefaultResourceManager);
		}

		/// <summary>
		/// Returns the value of the ResourceKey property related to the specified object.
		/// </summary>
		/// <param name="element">The item to check.</param>
		/// <returns></returns>
		public static string GetResourceKey(DependencyObject element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return element.GetValue(ResourceKeyProperty) as string;
		}

		/// <summary>
		/// Set the value of the ResourceKey property related to the specified object.
		/// </summary>
		/// <param name="element">The item to be initialized.</param>
		/// <param name="value">The supplyed value.</param>
		public static void SetResourceKey(DependencyObject element, string value)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			element.SetValue(ResourceKeyProperty, value);
		}

		/// <summary>
		/// Returns a string related to the specified key and culture.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <returns>A value relative to the specified key.</returns>
		public virtual string GetStringOverride(string key)
		{
			return LocalizationManager.GetString(key,
				this.Culture ?? LocalizationManager.DefaultCulture,
				this.ResourceManager ?? LocalizationManager.DefaultResourceManager);
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		private static void OnResourceKeyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			string resourceKey = e.NewValue as string;
			if (resourceKey == null)
			{
				return;
			}
			string resourceData = LocalizationManager.GetString(resourceKey);

			if (resourceData != null)
			{
				ILocalizable localizable = d as ILocalizable;
				if (localizable != null)
				{
					localizable.SetString(resourceData);
				}
                else if (d is IWindow)
                {
                    (d as IWindow).Title = resourceData;
                }
                else if (d is AccessText)
                {
                    (d as AccessText).Text = resourceData;
                }
                else if (d is GroupBox)
                {
                    (d as GroupBox).Header = resourceData;
                }
				else if (d is TextBox)
				{
					(d as TextBox).Text = resourceData;
				}
				else if (d is TextBlock)
				{
					(d as TextBlock).Text = resourceData;
				}
				else if (d is ContentControl)
				{
					(d as ContentControl).Content = resourceData;
				}
				else if (d is ContentPresenter)
				{
					(d as ContentPresenter).Content = resourceData;
				}
				else if (d is HeaderedContentControl)
				{
					(d as HeaderedContentControl).Header = resourceData;
				}
				else if (d is HeaderedItemsControl)
				{
					(d as HeaderedItemsControl).Header = resourceData;
				}

				else if (d is DiscreteObjectKeyFrame)
				{
					(d as DiscreteObjectKeyFrame).Value = resourceData;
				}
			}
		}

		private static string GetString(string key, CultureInfo culture, ResourceManager resourceManager)
		{
			string data = null;
			if (resourceManager != null)
			{
				try
				{
					data = (culture == null) ?
						resourceManager.GetString(key) :
						resourceManager.GetString(key, culture);
				}
				catch (System.InvalidOperationException)
				{
				}
				catch (MissingManifestResourceException)
				{
				}
			}
			return data ?? SR.GetString(key);
		}
	}
}
