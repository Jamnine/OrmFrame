using System;


using System.Windows;


namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Contains state information and event data associated with a parse date or time routed event.
	/// </summary>
	public class ParseDateTimeEventArgs : RadRoutedEventArgs
	{
		/// <summary>
        /// Initializes a new instance of the Telerik.Windows.Controls.ParseDateTimeEventArgs class.
		/// </summary>
		public ParseDateTimeEventArgs(RoutedEvent routedEvent, string text, DateTime previousValue, DateTime? result, bool isSuccessful)
			: base(routedEvent)
		{
			this.TextToParse = text;
			this.PreviousValue = previousValue;
			this.Result = result;
			this.IsParsingSuccessful = isSuccessful;
		}

		/// <summary>
		/// Gets the string that is being parsed.
		/// </summary>
		public string TextToParse { get; private set; }

		/// <summary>
        /// Gets the value before it's being parsed.
		/// </summary>
		public DateTime PreviousValue { get; private set; }

		/// <summary>
		/// Gets or sets the result of the parsing. Default value is null.
		/// </summary>
		/// <remarks>
		/// Use this property to change the result of the parsing,
		/// if you want to have custom logic for parsing.
		/// </remarks>
        /// <returns>
        /// The datetime object currently parsed. The default is null.
        /// </returns>
		public DateTime? Result { get; set; }

		/// <summary>
        /// Gets or sets a value that indicates whether the parsing 
		/// is successfull or not.
		/// </summary>
		/// <remarks>
		/// Use this property to change the result of the parsing,
		/// if you want to have custom logic for parsing.
		/// </remarks>
		public bool IsParsingSuccessful { get; set; }
	}
}
