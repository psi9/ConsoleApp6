using System;

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

            
            Console.WriteLine("Hello World!");
        }
    }
}
