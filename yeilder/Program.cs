using System;
using System.Collections;

namespace yeilder
{
    class Collection
    {
        public static IEnumerable Yield(int a, int b)
        {
            for (var x = 0; x < b; x++)
                yield return a + b + x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in Collection.Yield(2, 10))
                Console.WriteLine(i);
            Console.WriteLine("Hello World!");
        }
    }
}
