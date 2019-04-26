using System;
using System.Globalization;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    internal struct DateSpan : IDateSpan
    {
        private readonly DateTime end;
        private readonly DateTime start;

        public DateSpan(DateTime start, DateTime end)
        {
            this.start = start;
            this.end = end;
        }

        public DateSpan(IDateSpan other)
        {
            this.start = other.Start;
            this.end = other.End;
        }

        public DateTime End
        {
            get
            {
                return this.end;
            }
        }

        public DateTime Start
        {
            get
            {
                return this.start;
            }
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "Start: {0}, End: {1}", this.start, this.end);
        }
    }
}