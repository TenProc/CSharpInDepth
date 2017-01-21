using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    public class DateTimeRange : Range<DateTime>
    {
        private readonly TimeSpan step;
        public DateTimeRange(DateTime start, DateTime end) : this(start, end, TimeSpan.FromDays(1))
        {
        }

        public DateTimeRange(DateTime start, DateTime end, TimeSpan timeSpan) : base(start, end)
        {
            this.step = timeSpan;
        }

        protected override DateTime GetNextValue(DateTime value)
        {
            return value + step;
        }
    }

    public class Int32Range : Range<int>
    {
        private int step;

        public Int32Range(int start, int end) : this(start, end, 1)
        {
        }

        public Int32Range(int start, int end, int step) : base(start, end)
        {
            this.step = step;
        }

        protected override int GetNextValue(int value)
        {
            return value + step;
        }
    }
}
