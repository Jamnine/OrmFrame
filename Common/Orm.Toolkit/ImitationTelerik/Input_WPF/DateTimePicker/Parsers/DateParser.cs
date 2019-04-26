using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal class DateParser : DateParserBase
	{
		/// <summary>
		/// 
		/// </summary>
		public IEnumerable<string> MonthNames
		{
			get
			{
				return this.DateTimeFormat.AbbreviatedMonthNames.Union(this.DateTimeFormat.MonthNames);
			}
		}

		public override bool TryParse(string value, out DateTime result, DateTime current)
		{
			result = current;

			if (string.IsNullOrEmpty(value))
			{
				return false;
			}

			var normalizedDate = this.NormalizeDateString(value, current);
			var dateParts = normalizedDate.Split(new string[] { this.Separator }, StringSplitOptions.RemoveEmptyEntries);

			bool r = false;

			// TODO: Handle two parts separately.
			////if (dateParts.Length == 2)
			////{
			////    dateParts.Add(current.Year.ToString());
			////}

			// NOTE: Handle one part.
			if (dateParts.Length == 1)
			{
				result = current;

				int n;

				// We could have month or number. 
				// If it is a number it could be day or year.
				// It is year only if cannot be a day.
				if (int.TryParse(dateParts[0], out n))
				{
					var daysCount = this.DateTimeFormat.Calendar.GetDaysInMonth(current.Year, current.Month);

					// Is it a valid day?
					if (daysCount >= n && n > 0)
					{
						result = this.SetDay(current, n);
						r = true;
					}
					else if (n >= 0 && n < DateTime.MaxValue.Year)
					{
						// Is it a valid year?
						result = this.SetYear(current, n);
						r = true;
					}

					// If not - give up - we cannot parse it!
				}
				else
				{
					bool isLetter = Char.IsLetter(dateParts[0].ToString(), dateParts[0].Length - 1);

					if (isLetter)
					{
						// It is obviosly a month. We should find its number!
						var abbrMonths = this.DateTimeFormat.AbbreviatedMonthNames;
						var months = this.DateTimeFormat.MonthNames;
						int i = 0;
						for (i = 0; i < abbrMonths.Length - 1; i++)
						{
							if (abbrMonths[i].Equals(dateParts[0], StringComparison.CurrentCultureIgnoreCase) ||
								months[i].Equals(dateParts[0], StringComparison.CurrentCultureIgnoreCase))
								break;
						}
						result = this.SetMonth(current, i + 1);
						r = true;
					}
				}
			}
			else
			{
				DateTime dt = result;
				r = DateTime.TryParse(normalizedDate, this.DateTimeFormat, DateTimeStyles.None, out result);
				if (!r)
				{
					result = current;
				}
			}
			result = DateParserBase.MergeDateAndTime(result, current);
			return r;
		}

		protected string BuildCorrectFormatedDatePattern()
		{
			return string.Format(@"({0})((/|\.|-|{1})({0}))", this.BuildMonthPattern(), Regex.Escape(this.Separator)) + "{1,2}";
		}

		protected string BuildMonthPattern()
		{
			var patternBuilder = new StringBuilder(@"[0-9]+");

			foreach (var m in this.MonthNames.Where(s => !string.IsNullOrEmpty(s)))
			{
				patternBuilder.AppendFormat(@"|(?<=\b|\W|[0-9_]){0}(?=\b|\W|[0-9_])", m);
			}

			return patternBuilder.ToString();
		}

		protected List<string> SplitDateString(string baseDateString)
		{			
			var regex = new Regex(this.BuildMonthPattern(), RegexOptions.IgnoreCase);

			var dateParts = regex.Matches(baseDateString)
								 .OfType<Match>()
								 .Select(match => match.Value)
								 .Where(s => !string.IsNullOrEmpty(s))
								 .ToList();
			return dateParts;
		}

		private string NormalizeDateString(string baseDateString, DateTime current)
		{
			var result = string.Join(this.Separator, this.SplitDateString(baseDateString).ToArray());
			return result;
		}

		private DateTime SetMonth(DateTime current, int i)
		{
			if (i > 0 && i < 13)
			{
				return new DateTime(current.Year, i, current.Day);
			}
			return current;
		}

		private DateTime SetYear(DateTime current, int n)
		{
			if (n < 100)
			{
				// Find the Century and multiplay.
				n = ((current.Year / 100) * 100) + n;
			}

			return new DateTime(n, current.Month, current.Day);
		}

		private DateTime SetDay(DateTime source, int day)
		{
			return new DateTime(source.Year, source.Month, day);
		}
	}
}
