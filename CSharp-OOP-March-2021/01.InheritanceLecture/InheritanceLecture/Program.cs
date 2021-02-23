using System;
using System.Collections.Generic;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameObject> objects = new List<GameObject>();

            objects.Add(new Ball(new Position(5, 6), Direction.Right));
            objects.Add(new Racket(5, new Position(2, 3)));
            objects.Add(new Racket(5, new Position(2, 30)));

            foreach (var gameObject in objects)
            {
                gameObject.Draw();
            }

        }
    }
}
