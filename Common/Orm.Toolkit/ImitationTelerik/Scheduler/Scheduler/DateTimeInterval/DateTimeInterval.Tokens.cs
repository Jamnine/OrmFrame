using System;
using System.Collections.Generic;
using System.Globalization;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    public partial struct DateTimeInterval
    {
        private static class TokenParser
        {
            private static IEnumerable<Token> KnownTokens
            {
                get
                {
					yield return new HourToken(); 
					yield return new DayToken();
                    yield return new MonthToken();
                    yield return new WeekToken();
                }
            }

            internal static bool TryParse(string str, out Token token)
            {
                token = null;

                foreach (Token knownToken in KnownTokens)
                {
                    if (knownToken.TryInitialize(str))
                    {
                        token = knownToken;
                        return true;
                    }
                }

                return false;
            }
        }

        private abstract class Token
        {
            internal int Value { get; private set; }
            protected abstract char TokenEndChar { get; }

            protected internal bool TryInitialize(string str)
            {
                if (str.EndsWith(this.TokenEndChar.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    this.Value = int.Parse(str.Substring(0, str.Length - 1), CultureInfo.InvariantCulture);
                    if (this.Value < 0)
                    {
                        throw new ArgumentOutOfRangeException("str");
                    }
                    return true;
                }

                return false;
            }
        }

		private class HourToken : Token
		{
			protected override char TokenEndChar
			{
				get
				{
					return 'h';
				}
			}
		}
        private class DayToken : Token
        {
            protected override char TokenEndChar
            {
                get
                {
                    return 'd';
                }
            }
        }

        private class MonthToken : Token
        {
            protected override char TokenEndChar
            {
                get
                {
                    return 'm';
                }
            }
        }

        private class WeekToken : Token
        {
            protected override char TokenEndChar
            {
                get
                {
                    return 'w';
                }
            }
        }
    }
}
