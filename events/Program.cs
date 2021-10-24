using System;

namespace events
{
    class Program
    {
        public delegate void Delegator();
        class Class
        {
            int pole;
            public int Pole { 
                get { return pole;  } 
                set {
                    pole = value;
                    onChange();
                } 
            }
            public event Delegator Event;
            void onChange()
            {
                if (Event != null)
                {
                    Event();
                }
            }
        }
        static void Primer ()
        {
            Console.WriteLine("event raised");
        }

        static void Main(string[] args)
        {
            var cool = new Class();
            cool.Event += Primer;
            cool.Pole = 10;
            cool.Pole = 11;


            Console.WriteLine("Hello World!");
        }
    }
}
