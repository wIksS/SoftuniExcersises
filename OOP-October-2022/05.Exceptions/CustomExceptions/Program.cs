using System;

namespace CustomExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What shape do you want?");

            string shape = Console.ReadLine();
            
            Drawer drawer = new Drawer();

            try
            {
                drawer.Draw(shape);
            }
            catch (ShapeNotDrawableException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Wrong type was: {ex.ShapeType}");
            }
        }
    }
}
