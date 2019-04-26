using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal class DayOfWeekParser : DateParserBase
	{
		public override bool TryParse(string value, out DateTime result, DateTime current)
		{
			result = current;

			if (string.IsNullOrEmpty(value))
			{
				return false;
			}

			var patternBuilder = new StringBuilder();
			var abbrDays = this.DateTimeFormat.AbbreviatedDayNames;
			var days = this.DateTimeFormat.DayNames;
			for (int i = 0; i < abbrDays.Length; i++)
			{
				patternBuilder.AppendFormat(@"|(?<{0}>(?<=\b|\W){0}(?=\b|\W)|(?<=\b|\W){1}(?=\b|\W))", abbrDays[i], days[i]);
			}

			patternBuilder.Remove(0, 1); // Remove the first |.

			var pattern = patternBuilder.ToString();
			var regex = new Regex(pattern, RegexOptions.IgnoreCase);
			var match = regex.Match(value);
			result = current;
			if (match.Success)
			{
				// Note: There is implicit group for the whole expression. We are not interested in it.
				// What we do here is to find the index of the day matched.
				var index = this.FindMatchingGroupIndex(match.Groups.Cast<Group>().Skip(1).ToList());

				var r = index - (int)result.DayOfWeek;
				result = result.AddDays(r);

				return true;
			}
			return false;
		}

		// Finds the index of the first successful grup.
		private int FindMatchingGroupIndex(List<Group> groups)
		{
			return groups.IndexOf(groups.First(g => g.Success));
		}
	}
}
