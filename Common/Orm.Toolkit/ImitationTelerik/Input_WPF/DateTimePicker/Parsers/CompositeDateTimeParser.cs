using System;
using System.Collections.Generic;
using System.Globalization;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// 
	/// </summary>
	internal class CompositeDateTimeParser : List<IDateTimeParser>, IDateTimeParser
	{
		/// <summary>
		/// 
		/// </summary>
		public DateTimeFormatInfo DateTimeFormat
		{
			get
			{
				return this.Count == 0 ? default(DateTimeFormatInfo) : this[0].DateTimeFormat;
			}
			set
			{
				foreach (var parser in this)
				{
					parser.DateTimeFormat = value;
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public DateTimePickerFormat Format
		{
			get
			{
				return this.Count == 0 ? default(DateTimePickerFormat) : this[0].Format;
			}
			set
			{
				foreach (var parser in this)
				{
					parser.Format = value;
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <param name="result"></param>
		/// <param name="current"></param>
		/// <returns></returns>
		public bool TryParse(string value, out DateTime result, DateTime current)
		{
			result = current;

			if (string.IsNullOrEmpty(value))
			{
				return false;
			}

			foreach (var parser in this)
			{
				parser.DateTimeFormat = this.DateTimeFormat;
				if (parser.TryParse(value, out result, current))
					return true;
			}
			result = current;
			return false;
		}
	}
}
