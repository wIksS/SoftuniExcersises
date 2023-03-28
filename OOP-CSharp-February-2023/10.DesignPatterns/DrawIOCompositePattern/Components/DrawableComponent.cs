using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawIOCompositePattern.Components
{
    public abstract class DrawableComponent : Component
    {

        public DrawableComponent(Position position) : base(position)
        {

        }

        public abstract char[,] GetShapeMatrix();

        public override void Draw()
        {
            Console.ForegroundColor = color;
            char[,] shape = GetShapeMatrix();

            for (int row = 0; row < shape.GetLength(0); row++)
            {
                for (int col = 0; col < shape.GetLength(1); col++)
                {
                    Console.SetCursorPosition(position.X + row, position.Y + col);
                    Console.Write(shape[row,col]);
                }
            }
            

            base.Draw();
        }
    }
}
