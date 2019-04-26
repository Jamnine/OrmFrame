using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Enables a user to quickly access items in a set by typing prefixes of strings.
	/// </summary>
	public static class TextSearch
	{
		/// <summary>
		/// Identifies the TextPath attached property.
		/// </summary>

		public static readonly DependencyProperty TextPathProperty = System.Windows.Controls.TextSearch.TextPathProperty.AddOwner(typeof(TextSearch));

		/// <summary>
		/// Identifies the Text attached property.
		/// </summary>

		public static readonly DependencyProperty TextProperty = System.Windows.Controls.TextSearch.TextProperty.AddOwner(typeof(TextSearch));


		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
		static TextSearch()
		{
			AutoCompleteTimeout = TimeSpan.FromMilliseconds(800);
		}

		/// <summary>
		/// Gets or sets the timeout after that the autocomplete buffer is reset.
		/// </summary>
		public static TimeSpan AutoCompleteTimeout { get; set; }

		/// <summary>
		/// Returns the string to that identifies the specified item.
		/// </summary>
		/// <param name="element">The element from which the property value is read.</param>
		/// <returns>The string that identifies the specified item.</returns>
		public static string GetText(DependencyObject element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return (string)element.GetValue(TextProperty);
		}

		/// <summary>
		/// Writes the Text attached property to the specified element.
		/// </summary>
		/// <param name="element">The element to which the property value is written.</param>
		/// <param name="value">The string that identifies the item.</param>
		public static void SetText(DependencyObject element, string value)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			element.SetValue(TextProperty, value);
		}

		/// <summary>
		/// Returns the name of the property that identifies an item in the specified element's collection.
		/// </summary>
		/// <param name="element">The element from which the property value is read.</param>
		/// <returns>The name of the property that identifies the item to the user.</returns>
		public static string GetTextPath(DependencyObject element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return (string)element.GetValue(TextPathProperty);
		}

		/// <summary>
		/// Writes the TextPath attached property to the specified element.
		/// </summary>
		/// <param name="element">The element to which the property value is written.</param>
		/// <param name="value">The name of the property that identifies an item.</param>
		public static void SetTextPath(DependencyObject element, string value)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			element.SetValue(TextPathProperty, value);
		}

		/// <summary>
		/// Creates a Func that compares the provided text with its parameter. The result depends on the TextSearchMode.
		/// </summary>
		public static Func<string, bool> CreateFullMatchFunc(string text, TextSearchMode mode)
		{
			var stringComparison = mode.IsCaseSensitive() ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

			return (string itemText) => itemText.Equals(text, stringComparison);
		}

		/// <summary>
		/// Creates a Func that compares the provided text with its parameter. The result depends on the TextSearchMode.
		/// </summary>
		public static Func<string, bool> CreatePartialMatchFunc(string text, TextSearchMode mode)
		{
			if (mode.IsContains())
			{
				if (mode.IsCaseSensitive())
				{
					return (string itemText) =>
						itemText.Contains(text);
				}
				else
				{
					return (string itemText) =>
						itemText.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1;
				}
			}
			else if (mode.IsStartsWith())
			{
				var stringComparison = mode.IsCaseSensitive() ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

				return (string itemText) => 
					itemText.StartsWith(text, stringComparison);
			}
			return null;
		}

		internal static string GetPrimaryTextFromItem(ItemsControl itemsControl, object item)
		{
			return GetPrimaryText(item, GetPrimaryTextPath(itemsControl));
		}

		internal static string GetPrimaryText(object item, string primaryTextPath)
		{
			if (item == null) return null;
			return GetPrimaryText(item, BindingExpressionHelper.CreateGetValueFunc(item.GetType(), primaryTextPath));
		}

		internal static string GetPrimaryText(object item, Func<object, object> getTextFunc)
		{
			DependencyObject d = item as DependencyObject;
			if (d != null)
			{
				string str = (string)d.GetValue(TextProperty);
				if (!string.IsNullOrEmpty(str))
				{
					return str;
				}
			}

			if (getTextFunc != null)
			{
				return ConvertToPlainText(getTextFunc(item));
			}

			return ConvertToPlainText(item);
		}

		internal static string ConvertToPlainText(object o)
		{
			FrameworkElement element = o as FrameworkElement;
			if (element != null)
			{
				string plainText = element.GetPlainText();
				if (plainText != null)
				{
					return plainText;
				}
			}

			if (o == null)
			{
				return string.Empty;
			}

			return o.ToString();
		}

		internal static string GetPrimaryTextPath(ItemsControl itemsControl)
		{
			string textPath = GetTextPath(itemsControl);
			if (string.IsNullOrEmpty(textPath))
			{
				textPath = itemsControl.DisplayMemberPath;
			}

			return textPath;
		}

		/// <summary>
		/// Finds the first matching item - if there is an item with text that is equal to the text parameter, returns its index, no 
		/// matter what the mode is. If there is no full match, returns -1. In both cases the matchIndexes output parameter contains
		/// the indexes of all matching items. The disabled item containers are excluded from the search results.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "4#")]
		internal static int FindMatchingItems(ItemsControl itemsControl, string text, TextSearchMode mode, int startIndex, out List<int> matchIndexes)
		{
			matchIndexes = new List<int>();

			ItemCollection items = itemsControl.Items;
			if (items.Count == 0)
			{
				return -1;
			}

			bool isEmptyText = string.IsNullOrEmpty(text);

			Func<string, bool> isFullMatch;
			Func<string, bool> isPartialMatch;

			if (isEmptyText)
			{
				isPartialMatch = isFullMatch = (string itemText) => false;
			}
			else
			{
				isFullMatch = CreateFullMatchFunc(text, mode);
				isPartialMatch = CreatePartialMatchFunc(text, mode) ?? isFullMatch;
			}

			Func<object, object> getTextFunc = null;

			int fullMatchIndex = -1;

			for (int i = startIndex; i < items.Count; i++)
			{
				object item = items[i];

				if (getTextFunc == null && item != null)
				{
					getTextFunc = BindingExpressionHelper.CreateGetValueFunc(item.GetType(), GetPrimaryTextPath(itemsControl));
				}

				var container = itemsControl.ItemContainerGenerator.ContainerFromIndex(i) as Control;
				if (container != null && !container.IsEnabled)
				{
					continue;
				}

				string primaryText = GetPrimaryText(item, getTextFunc);

				if (fullMatchIndex < 0 && isFullMatch(primaryText))
				{
					fullMatchIndex = i;

					matchIndexes.Insert(0, fullMatchIndex);
				}
				else if (isPartialMatch(primaryText))
				{
					matchIndexes.Add(i);
				}
			}
			return fullMatchIndex;
		}

		private static string GetPrimaryText(FrameworkElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}

			string text = GetText(element);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}

			return element.GetPlainText();
		}

		private static CultureInfo GetCulture(DependencyObject element)
		{
			object obj2 = element.GetValue(FrameworkElement.LanguageProperty);
			CultureInfo specificCulture = null;
			if (obj2 != null)
			{

				System.Windows.Markup.XmlLanguage language = (System.Windows.Markup.XmlLanguage)obj2;
				try
				{
					specificCulture = language.GetSpecificCulture();
				}
				catch (InvalidOperationException)
				{
				}

			}
			return specificCulture;
		}
	}
}