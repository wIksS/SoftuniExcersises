using CompositePattern.Components;
using System;
using System.Threading;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent page = new Component(new Position(0, 0));


            IComponent rec = BuildRec(new Position(0, 0));
            IComponent rec2 = BuildRec(new Position(50, 10));

            page.Add(rec);
            page.Add(rec2);

            rec.Draw();

            while (true)
            {
                Position movePosition = new Position(1, 1);
                Console.Clear();
                page.Move(movePosition);

               // rec2.Move(new Position(1,-1));

                page.Draw();

                Thread.Sleep(200);
            }

            Console.ReadLine();
        }

        public static IComponent BuildRec(Position pos)
        {
            IComponent rec = new Rectangle(new Position(15 + pos.X, 5 + pos.Y), 10);
            rec.Add(new Text(new Position(25 + pos.X, 5 + pos.Y), "Composite is cool"));
            rec.Add(new Text(new Position(35 + pos.X, 2 + pos.Y), "Something"));
            rec.Add(new Text(new Position(30 + pos.X, 9 + pos.Y), "3"));
            rec.Add(new Text(new Position(5 + pos.X, 8 + pos.Y), "4141"));

            return rec;
        }
    }
}
