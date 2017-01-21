using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example6
{
    class Program
    {
        static readonly string Padding = new string(' ', 30);

        static IEnumerable<int> GetEnumerable()
        {
            Console.WriteLine("{0} Start of GetEnumerator()", Padding);

            for (int i = 0; i < 3; i++)
            {
                yield return i;
            }
        }
        static void Main(string[] args)
        {
            DateTime stop = DateTime.Now.AddSeconds(2);
            foreach (int i in CountWithTimeLimit(stop))
            {
                Console.WriteLine("Received {0}", i);
                Thread.Sleep(300);
            }
            return;
        }

        static void Example6_5 (string[] args)
        {
            var iterable = GetEnumerable();
            var iterator = iterable.GetEnumerator();

            while (true)
            {
                var result = iterator.MoveNext();
                if (!result)
                    break;
            }
        }

        static IEnumerable<int> CountWithTimeLimit(DateTime limit)
        {
            for(int i = 0; i < 0; i ++)
            {
                if(DateTime.Now >= limit)
                {
                    yield break;
                }
                yield return i;
            }
        }
    }
}
