using System;
using System.Collections;
using System.Collections.Generic;

namespace yeilder
{
    class Collection
    {
        public static IEnumerable Yield(int a, int b)
        {
            for (var x = 0; x < b; x++)
                yield return a + b + x;
        }
        public IEnumerable<int> Up(int start, int end)
        {
            int index = start;
            while (index < end)
            {
                yield return index;
                index++;
            }
        }
        public IEnumerable<int> Down(int start, int end)
        {
            int index = start;
            while (index > end)
            {
                yield return index;
                index--;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in Collection.Yield(2, 10))
                Console.WriteLine(i);

            var c = new Collection();
            foreach(var i in c.Down(5,3))
                Console.WriteLine(i);
            foreach (var i in c.Up(5, 13))
                Console.WriteLine(i);

            Console.WriteLine("Hello World!");
        }
    }
}
