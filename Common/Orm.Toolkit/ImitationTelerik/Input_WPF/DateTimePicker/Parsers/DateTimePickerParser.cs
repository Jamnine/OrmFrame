using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal class DateTimePickerParser : DateParser
	{
		private IDateTimeParser timeParser;
		private IDateTimeParser otherParsers;

		public DateTimePickerParser()
		{
			this.timeParser = new DesignatorParser();
			this.otherParsers = new CompositeDateTimeParser { new DayOfWeekParser(), new SpecialNamesParser() };
		}

		public override bool TryParse(string value, out DateTime result, DateTime current)
		{
			this.UpdateDateTimeFormat();
			string value1 = value;

			var timeRegexString = string.Format(@"\d+(:\d+)?((:\d+)|(:\d+)?((\W|_)*(AM|PM|A|P|{0}|{1})(?=\W|\b|_|\d+)))", this.DateTimeFormat.AMDesignator, this.DateTimeFormat.PMDesignator);
			bool isTimeParsed = false;

			//// \d+(:\d+)?((:\d+)|(:\d+)?((\W|_)*(AM|MP|A|P)(?=\W|\b|_|\d+))) - should change : with separator, AM, PM, etc. as well.

			var timeRegex = new Regex(timeRegexString, RegexOptions.IgnoreCase);

			var match = timeRegex.Match(value);
			if (match.Success)
			{
				isTimeParsed = this.TryParseTime(match.Value, out current, current);
				if (isTimeParsed)
				{
					value = value1 = value.Remove(match.Index, match.Length);
				}
			}
			else
			{
				var dateRegexString = this.BuildCorrectFormatedDatePattern();
				var dateRegex = new Regex(dateRegexString, RegexOptions.IgnoreCase);
				var dateMatch = dateRegex.Match(value);

				if (dateMatch.Success)
				{
					isTimeParsed = this.TryParseTime(value.Remove(dateMatch.Index, dateMatch.Length), out current, current);
					if (isTimeParsed)
					{
						value = value1 = dateMatch.Value;
					}
				}
				else
				{
					var dateTimeParts = this.SplitDateString(value);

					// May be we should check the format - how many parts it contains.
					if (dateTimeParts.Count > 3)
					{
						var timeParts = dateTimeParts.Skip(3).ToArray();
						isTimeParsed = this.TryParseTime(string.Join(":", timeParts), out current, current);
					}
					
					value1 = string.Join(this.Separator, dateTimeParts.Take(3).ToArray());
				}
			}

			return base.TryParse(value1, out result, current) ||
					this.TryParseDate(value, out result, current) ||
					isTimeParsed;
		}

		private bool TryParseTime(string value, out DateTime result, DateTime current)
		{
			if (this.timeParser.TryParse(value, out result, current))
			{
				return true;
			}
			else
			{
				result = current;
				return false;
			}
		}

		private bool TryParseDate(string value, out DateTime result, DateTime current)
		{
			if (this.otherParsers.TryParse(value, out result, current))
			{
				return true;
			}
			else
			{
				result = current;
				return false;
			}
		}		

		private void UpdateDateTimeFormat()
		{
			this.timeParser.DateTimeFormat = this.DateTimeFormat;
			this.otherParsers.DateTimeFormat = this.DateTimeFormat;
		}
	}
}
