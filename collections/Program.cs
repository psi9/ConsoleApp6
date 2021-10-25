using System;
using System.Collections;

namespace collections
{
    class Collection : IEnumerable, IEnumerator
    {
        public int[] array = { 1, 2, 3 };

        int index = -1;

        public object Current => array[index];

        public bool MoveNext()
        {
            if (index < array.Length - 1)
            {
                index++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            index = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Collection();
            foreach (var i in x)
                Console.WriteLine(i);
            Console.WriteLine("Hello World!");
        }
    }
}
