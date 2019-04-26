using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal class TimeParser : IDateTimeParser
	{
		private enum ParsingValue
		{
			/// <summary>
			/// 
			/// </summary>
			Hours,

			/// <summary>
			/// 
			/// </summary>
			Minutes,

			/// <summary>
			/// 
			/// </summary>
			Seconds
		}

		public DateTimeFormatInfo DateTimeFormat
		{
			get;
			set;
		}

		public DateTimePickerFormat Format
		{
			get;
			set;
		}

		public virtual bool TryParse(string value, out DateTime result, DateTime current)
		{
			result = current;

			if (string.IsNullOrEmpty(value))
			{
				return false;
			}

			result = new DateTime(current.Year, current.Month, current.Day, 0, 0, 0);

			var normalizinqString = this.NormalizaValue(value);
			double timeSpanHours;
			double timeSpanMinutes;
			double timeSpanSeconds;
			bool isSucceeded = false;

			// Supporting only hours, minutes and seconds parsing.
			if (normalizinqString.Count > 0 && normalizinqString.Count < 4)
			{
				var hour = normalizinqString[0].Value;
				var minutes = normalizinqString.Count > 1 ? normalizinqString[1].Value : null;
				var seconds = normalizinqString.Count > 2 ? normalizinqString[2].Value : null;

				if (double.TryParse(hour, out timeSpanHours))
				{
					isSucceeded = this.AddTokens(timeSpanHours, ParsingValue.Hours, ref result);
				}
				if (double.TryParse(minutes, out timeSpanMinutes))
				{
					isSucceeded &= this.AddTokens(timeSpanMinutes, ParsingValue.Minutes, ref result);
				}
				if (double.TryParse(seconds, out timeSpanSeconds))
				{
					isSucceeded &= this.AddTokens(timeSpanSeconds, ParsingValue.Seconds, ref result);
				}
			}
			return isSucceeded;
		}

		protected virtual MatchCollection NormalizaValue(string value)
		{
			////var patternWithSeparator = "([:]?)([0-9]+)([:]?)";

			var pattern = "[0-9]+";
			var result = Regex.Matches(value, pattern);
			return result;
		}

		private bool AddTokens(double value, ParsingValue parsingValue, ref DateTime result)
		{
			switch (parsingValue)
			{
				case ParsingValue.Hours: return this.AddHours(value, ref result);
				case ParsingValue.Minutes: return this.AddMinutes(value, ref result);
				case ParsingValue.Seconds: return this.AddSeconds(value, ref result);
			}
			return false;
		}

		private bool IsValidToken(double value, ParsingValue parsingValue)
		{
			switch (parsingValue)
			{
				case ParsingValue.Hours: return value >= 0 && value <= 24;
				case ParsingValue.Minutes: return value >= 0 && value < 60;
				case ParsingValue.Seconds: return value >= 0 && value < 60;
			}
			return false;
		}

		private bool AddHours(double value, ref DateTime result)
		{
			if (this.IsValidToken(value, ParsingValue.Hours))
			{
				var hourSpan = TimeSpan.FromHours(value);
				result = result.Add(hourSpan);
				return true;
			}
			return this.StartParsing(value, ParsingValue.Hours, ref result);
		}

		private bool AddMinutes(double value, ref DateTime result)
		{
			if (this.IsValidToken(value, ParsingValue.Minutes))
			{
				var minSpan = TimeSpan.FromMinutes(value);
				result = result.Add(minSpan);
				return true;
			}
			return this.StartParsing(value, ParsingValue.Minutes, ref result);
		}

		private bool AddSeconds(double value, ref DateTime result)
		{
			if (this.IsValidToken(value, ParsingValue.Seconds))
			{
				var secSpans = TimeSpan.FromSeconds(value);
				result = result.Add(secSpans);
				return true;
			}
			return false;
		}

		private bool StartParsing(double value, ParsingValue parsingValue, ref DateTime result)
		{
			for (int i = 10; i < Math.Pow(10, 6); i *= 10)
			{
				int h = (int)(value / i);

				if (this.IsValidToken(h, parsingValue))
				{
					this.AddTokens(h, parsingValue, ref result);

					double min = value % i;

					return this.AddTokens(min, (parsingValue == ParsingValue.Hours ? ParsingValue.Minutes : ParsingValue.Seconds), ref result);
				}
			}
			return false;
		}
	}
}
