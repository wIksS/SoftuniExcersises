using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            var pi = Math.PI;
            Console.WriteLine(MathClass.CalculateArea(5,6));
            //Painter painter = new Painter();
            //painter.PrintRec();

            Painter.StaticSize = 2;
            Painter.PrintTriangle();
        }
    }

    class Painter
    {
        public Painter()
        {
            Size = 4;
        }

        public int Size { get; set; }

        public static int StaticSize { get; set; }

        public static void PrintTriangle()
        {                    
            for (int i = 0; i < Painter.StaticSize; i++)
            {
                Console.WriteLine("Printing triangle");
            }
        }

        public void PrintRec()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine("Printing rectangle");
            }
        }
    }
}
