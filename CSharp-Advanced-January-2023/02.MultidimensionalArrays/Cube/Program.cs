using System;
using System.Linq;
using OpenTK;

class Cubes
{
    static void Main()
    {
        var resolution = 25;
        var points = from i in Enumerable.Range(1, 8) select new Vector3(i / 4 % 2 * 2 - 1, i / 2 % 2 * 2 - 1, i % 2 * 2 - 1);
        var lines = from a in points
                    from b in points
                    where (a - b).Length == 2  // adjacent points
                       && a.X + a.Y + a.Z > b.X + b.Y + b.Z // select each pair once
                    select new { a, b };
        var t = 0f;
        while (true)
        {
            t += .1f;
            var projection = Matrix4.CreatePerspectiveFieldOfView(.8f, 1, .01f, 100f);
            var view = Matrix4.LookAt(2 * new Vector3((float)Math.Sin(t), .5f, (float)Math.Cos(t)), Vector3.Zero, Vector3.UnitY);
            Console.Clear();
            foreach (var line in lines)
            {
                for (int i = 0; i < resolution; i++)
                {
                    var point = (1f / resolution) * (i * line.a + (resolution - 1 - i) * line.b); // interpolate a point between the two corners
                    var p1 = 5 * Vector3.Transform(point, view * projection) + new Vector3(30, 20, 0);
                    Console.SetCursorPosition((int)p1.X, (int)p1.Y);
                    Console.Write("#");
                }
            }
            Console.ReadKey();
        }
    }
}