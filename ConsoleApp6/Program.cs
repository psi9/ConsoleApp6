using System;
using System.Collections.Generic;

namespace ConsoleApp6 {


    class Program
        
    {
        delegate void Delegator();
        static void Privet()
        {
            Console.WriteLine("111");
        }
        public class Point
        {
            private double x;
            private double y;

            public double X
            {
                get { return x; }
                set { x = value; }
            }

            public double Y
            {
                get { return y; }

                set { y = value; }
            }


 
        }


        static void Main(string[] args)
        {
            Delegator delegator = Privet;
            Delegator delegator2 = () => Console.WriteLine("222");

            var xxx = new List<int>(3);
            xxx.Add(1);
            xxx.Add(2);
            xxx.Add(3);
            xxx.Add(4);
            xxx.Add(5);
            xxx.Add(6);
            foreach (var item in xxx)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
