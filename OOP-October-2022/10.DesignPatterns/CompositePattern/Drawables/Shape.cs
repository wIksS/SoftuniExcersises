using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Drawables
{
    public class Shape : Drawable
    {
        public Shape(Position pos) : base(pos) { }

        public override void Draw()
        {
            base.Draw();

            DrawingUtility.DrawMatrix(shape, Position);
        }

        public override void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    if (Position.Top > 0)

                        Position.Top--;
                    break;
                case Direction.Down:
                    Position.Top++;
                    break;
                case Direction.Left:
                    if (Position.Left > 0)
                        Position.Left--;
                    break;
                case Direction.Right:
                    Position.Left++;
                    break;
                default: break;
            }

            base.Move(direction);
        }
    }
}
