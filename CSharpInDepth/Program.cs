using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Example_5_8();
            return;
        }

        static void Example_5_6()
        {
            List<int> x = new List<int>();
            x.Add(5);
            x.Add(10);
            x.Add(15);

            x.ForEach(delegate (int n) { Console.WriteLine(Math.Sqrt(n)); });
        }

        static void Example_5_7()
        {
            Predicate<int> isEven = delegate (int n)
            {
                return n % 2 == 0;
            };

            Console.WriteLine(isEven(4));
            Console.WriteLine(isEven(5));
        }

        static void Example_5_8()
        {
            SortAndShowFiles("Sorted by name: ", delegate (FileInfo first, FileInfo second)
            { return first.Name.CompareTo(second.Name); }
            );

            SortAndShowFiles("Sorted by length ", delegate (FileInfo first, FileInfo second)
            { return first.Length.CompareTo(second.Length); }
            );
        }

        //Example 5_9
        //파라미터를 사용하지 않는 경우에는 파라미터 목록 제외하고 델리게이트를 사용하면 된다.

    static void SortAndShowFiles(string title, Comparison<FileInfo> sortOrder)
    {
        FileInfo[] files = new DirectoryInfo(@"c:\").GetFiles();
        Array.Sort(files, sortOrder);
        Console.WriteLine(title);

        foreach (FileInfo file in files)
        {
            Console.WriteLine(" {0} ({1} bytes)", file.Name, file.Length);
        }
    }
}
}
