using System;
using System.Reflection;
using System.Threading;

namespace InheritanceOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            var fields = shape.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var field in fields)
            {
                Console.WriteLine($"key: {field.Name} value: {field.GetValue(shape)}");
            }
            return;


            //shape.maxDrawCount = -1;
            shape.Draw();
            //shape.maxDrawCount = -1;
            //Console.WriteLine(shape.CanDrawShape());
            //shape.drawCount = 555;
            //shape.x = -1;
            for (int i = 0; i < 5000; i++)
            {
                Thread.Sleep(1);
                Console.Clear();
                shape.Draw();
            }
        }
    }
}
