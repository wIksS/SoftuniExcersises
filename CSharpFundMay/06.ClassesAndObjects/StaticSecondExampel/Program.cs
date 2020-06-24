using System;

namespace StaticSecondExampel
{
    class Program
    {
        static void Main(string[] args)
        {
            Point.PointsCount = 1555;
            Console.WriteLine(Point.PointsCount);

            Point lowerLeft = Point.RandomPoint(); //new Point() { x = -5, y = -3 };
            lowerLeft.PrintPoint();
            Point upperRight = Point.RandomPoint();//new Point() { x = 5, y = 3 };
            upperRight.PrintPoint();

            Console.WriteLine(lowerLeft.isThirdQuadrant());
            while (!lowerLeft.isThirdQuadrant())
            {
                lowerLeft = Point.RandomPoint();
                Console.WriteLine($"Generating point:");
                lowerLeft.PrintPoint();
            }
            Console.WriteLine(lowerLeft.isThirdQuadrant());

        }
    }

    public class Point
    {
        public static int PointsCount;
        public int x;
        public int y;

        public bool isThirdQuadrant()
        {
            if (x < 0 && y < 0)
            {
                return true;
            }

            return false;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"x:{this.x} y:{this.y}");
        }

        public static void PrintPointStatic(Point point)
        {
            Console.WriteLine($"x:{point.x} y:{point.y}");
        }

        public static Point RandomPoint()
        {
            Random rand = new Random();
            return new Point() { x = rand.Next(-100,100), y = rand.Next(-100, 100) };
        }
    }
}
