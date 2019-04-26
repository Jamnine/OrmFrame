using System.Collections.Generic;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    public partial struct DateTimeInterval
    {
        private class Tokenizer
        {
            private readonly string input;
            private readonly int length;
            private int currentPosition;
            private int previousTokenEnd;

            internal Tokenizer(string input)
            {
                this.input = input;
                this.length = input.Length;
            }

            internal IList<Token> Tokenize()
            {
                var tokens = new List<Token>();
                this.currentPosition = 0;

                this.SkipBlanks();

                this.previousTokenEnd = this.currentPosition;

                while (this.currentPosition < this.length)
                {
                    Token token;
                    if (this.GetNextToken(out token))
                    {
                        tokens.Add(token);
                        this.previousTokenEnd = this.currentPosition + 1;
                        this.SkipBlanks();
                    }

                    this.currentPosition++;
                }

                return tokens;
            }

            private bool GetNextToken(out Token token)
            {
                string tokenString = this.input.Substring(
                    this.previousTokenEnd,
                    this.currentPosition - this.previousTokenEnd + 1);

                return TokenParser.TryParse(tokenString, out token);
            }

            private void SkipBlanks()
            {
                char ch = this.input[this.currentPosition];
                while ((ch == ' ') || (ch == '\t'))
                {
                    if (this.currentPosition < this.length)
                    {
                        this.currentPosition++;
                    }
                }
            }
        }
    }
}