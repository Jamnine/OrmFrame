using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal class SpecialNamesParser : DateParserBase
	{
		public override bool TryParse(string value, out DateTime result, DateTime current)
		{
			result = current;

			if (string.IsNullOrEmpty(value))
			{
				return false;
			}

			var patternBuilder = new StringBuilder();
			foreach (var special in SpecialNames.SpecialNamesSpecification.Keys)
			{
				patternBuilder.AppendFormat(@"|(?<{0}>(?<=\b|\W){0}(?=\b|\W))", special);
			}

			patternBuilder.Remove(0, 1); // Remove the first |.

			var pattern = patternBuilder.ToString();
			var regex = new Regex(pattern, RegexOptions.IgnoreCase);
			var match = regex.Match(value);

			result = DateParserBase.MergeDateAndTime(DateTime.Now, current);

			if (match.Success)
			{
				var index = this.FindMatchingGroupIndex(match.Groups.Cast<Group>().Skip(1).ToList());
				var specialName = regex.GroupNameFromNumber(index + 1);

				result = result.AddDays(SpecialNames.SpecialNamesSpecification[specialName]);

				return true;
			}
			return false;
		}

		private int FindMatchingGroupIndex(List<Group> groups)
		{
			return groups.IndexOf(groups.First(g => g.Success));
		}
	}
}
