using System;

namespace Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();

            //a.Hi();

            //a = new B();
            //a.Hi();

            C b = new C();
            b.Hi();
        }
    }

    class A
    {
        public virtual void Hi()
        {
            Console.WriteLine("A Hi");
        }
    }

    class B : A
    {
        public sealed  override void Hi()
        {
            Console.WriteLine("B Hi");
        }
    }

    class C : B
    {
        public new void Hi()
        {
            Console.WriteLine("C Hi");
        }
    }
}
