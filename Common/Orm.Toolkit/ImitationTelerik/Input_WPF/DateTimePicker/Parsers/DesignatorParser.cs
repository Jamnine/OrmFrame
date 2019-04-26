using System;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal class DesignatorParser : TimeParser
	{
		public override bool TryParse(string value, out DateTime result, DateTime current)
		{
			result = current;

			if (string.IsNullOrEmpty(value))
			{
				return false;
			}

			var tempValue = value;

			var lastSymbol = tempValue[tempValue.Length - 1];
			if (!Char.IsDigit(lastSymbol))
			{
				tempValue = value.Substring(0, value.Length - 1);
			}

			var isEndWithAMDesignator = this.CheckForAMDesignorSequential(value);
			var isEndWithPMDesignator = this.CheckForPMDesignorSequential(value);

			var isParsed = base.TryParse(tempValue, out result, current);
			if (isParsed)
			{
				if (this.DateTimeFormat.AMDesignator.ToLower().IndexOf(lastSymbol.ToString().ToLower()) == 0 || isEndWithAMDesignator)
				{
					if (result.Hour >= 12)
					{
						result = result.AddHours(-12);
					}
				}
				else if (this.DateTimeFormat.PMDesignator.ToLower().IndexOf(lastSymbol.ToString().ToLower()) == 0 || isEndWithPMDesignator)
				{
					if (result.Hour < 12)
					{
						result = result.AddHours(12);
					}
				}
				return true;
			}
			return false;
		}

		private bool CheckForAMDesignorSequential(string value)
		{
			bool isEndWithAMDesignator = value.Length - this.DateTimeFormat.AMDesignator.Length == value.ToLower().LastIndexOf(this.DateTimeFormat.AMDesignator.ToLower()) && value.Length >= this.DateTimeFormat.AMDesignator.Length;
			return isEndWithAMDesignator;
		}

		private bool CheckForPMDesignorSequential(string value)
		{
			bool isEndWithPMDesignator = value.Length - this.DateTimeFormat.AMDesignator.Length == value.ToLower().LastIndexOf(this.DateTimeFormat.PMDesignator.ToLower()) && value.Length >= this.DateTimeFormat.PMDesignator.Length;
			return isEndWithPMDesignator;
		}
	}
}
