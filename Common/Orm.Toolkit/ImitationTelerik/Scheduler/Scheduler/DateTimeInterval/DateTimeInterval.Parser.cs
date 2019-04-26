using System;
using System.Collections.Generic;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    public partial struct DateTimeInterval
    {
        private enum ParseError
        {
            /// <summary>
            /// Null argument.
            /// </summary>
            ArgumentNull,

            /// <summary>
            /// Invalid argument.
            /// </summary>
            ArgumentOutOfRange,

            /// <summary>
            /// Invalid format.
            /// </summary>
            Format,

            /// <summary>
            /// Type oferflow.
            /// </summary>
            Overflow
        }

        private class Parser
        {
            private ParseError error;

            internal DateTimeInterval Parse(string str)
            {
                DateTimeInterval interval;
                if (this.TryParse(str, out interval))
                {
                    return interval;
                }
                switch (this.error)
                {
                    case ParseError.Format:
                        throw new FormatException("Invalid string passed as argument");

                    case ParseError.Overflow:
                        throw new OverflowException("Value was either too large or too small for an Int32");

                    case ParseError.ArgumentOutOfRange:
                        throw new ArgumentOutOfRangeException("str", str, "Value should not be negative");

                    case ParseError.ArgumentNull:
                        throw new ArgumentNullException("str");
                }
                return default(DateTimeInterval);
            }

            internal bool TryParse(string str, out DateTimeInterval interval)
            {
                interval = default(DateTimeInterval);

                if (str == null)
                {
                    this.error = ParseError.ArgumentNull;
                    return false;
                }

                if (str.Length == 0)
                {
                    this.error = ParseError.Format;
                    return false;
                }

                IList<Token> tokens;
                var tokenizer = new Tokenizer(str);

                try
                {
                    tokens = tokenizer.Tokenize();
                }
                catch (FormatException)
                {
                    this.error = ParseError.Format;
                    return false;
                }
                catch (OverflowException)
                {
                    this.error = ParseError.Overflow;
                    return false;
                }
                catch (ArgumentOutOfRangeException)
                {
                    this.error = ParseError.ArgumentOutOfRange;
                    return false;
                }

                if (tokens.Count == 0 || tokens.Count > 2)
                {
                    this.error = ParseError.Format;
                    return false;
                }

				int hours = 0;
				int days = 0;
                int months = 0;
                int weeks = 0;

                foreach (Token token in tokens)
                {
					if (token is HourToken)
					{
						hours = token.Value;
					} 
					if (token is DayToken)
                    {
                        days = token.Value;
                    }
                    else if (token is MonthToken)
                    {
                        months = token.Value;
                    }
                    else if (token is WeekToken)
                    {
                        weeks = token.Value;
                    }
                }

                interval = new DateTimeInterval(hours, days, months, weeks);
                return true;
            }
        }
    }
}
