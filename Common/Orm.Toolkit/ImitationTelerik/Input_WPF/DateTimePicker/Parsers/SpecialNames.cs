using System.Collections.Generic;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal static class SpecialNames
	{
		private static Dictionary<string, int> specialNamesSpecification = new Dictionary<string, int>
		{
			{ "Today", 0 },
			{ "Tomorrow", 1 },
			{ "Yesterday", -1 }
		};

		public static Dictionary<string, int> SpecialNamesSpecification
		{
			get
			{
				return specialNamesSpecification;
			}
		}
	}
}
