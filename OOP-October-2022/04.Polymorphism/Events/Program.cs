using System;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new X();
            x.handler += (sender, e) => { Console.WriteLine($"First event called with {e}"); };

            x.handler += (sender, e) => { Console.WriteLine($"Second event called with {e}"); };

            x.Print();

            EventHandler<int> func = (object sender, int e) => { Console.WriteLine($"Third event called with {e}"); };
            x.handler += func;
            //x.handler -= func;

            x.Print();
        }
    }

    class X
    {
        public event EventHandler<int> handler;  

        public void Print()
        {
            Console.WriteLine("Hello");
            handler.Invoke(this, 55);
        }
    }
}
