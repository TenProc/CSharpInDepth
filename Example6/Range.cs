using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    public abstract class Range<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private readonly T start;
        public T Start
        {
            get
            {
                return start;
            }
        }
        private readonly T end;
        public T End
        {
            get
            {
                return end;
            }
        }


        public Range(T start, T end)
        {
            if (start.CompareTo(end) > 0)
                throw new ArgumentOutOfRangeException();

            this.start = start;
            this.end = end;
        }
        public IEnumerator<T> GetEnumerator()
        {
            T value = Start;
            while(value.CompareTo(End) < 0)
            {
                yield return value;
                value = GetNextValue(value);
            }

            if (value.CompareTo(End) == 0)
                yield return value;
        }

        protected abstract T GetNextValue(T value);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Contains(T value)
        {
            return Start.CompareTo(value) <= 0 && End.CompareTo(value) >= 0;
        }
    }
}
