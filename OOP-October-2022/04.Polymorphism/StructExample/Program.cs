using System;

namespace StructExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 5;

            var point2 = point;
            point2.X = 10;

            Console.WriteLine(point.X);
            Console.WriteLine(point2.X);
        }
    }

    struct Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public void Print()
        {

        }
    }
}
