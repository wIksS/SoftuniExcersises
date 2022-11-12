using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Square : IDrawable
    {
        public void Draw()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("@");
                }

                Console.WriteLine();
            }
        }
    }
}
