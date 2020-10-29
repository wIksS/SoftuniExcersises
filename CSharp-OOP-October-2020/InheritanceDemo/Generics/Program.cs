using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCart<string> cart = new StringCart<string>();
            string name = cart.Product;


        }
    }
}
