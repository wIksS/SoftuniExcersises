using InheritanceLecture.Conctract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture
{
    class Ball : GameObject, IMoveable
    {
        public Ball(Position position, Direction direction, IRenderer renderer)
            :base(position, renderer)
        {
            this.Direction = direction;
        }
        public Direction Direction { get; set; }

        public override void Draw()
        {
            Renderer.WriteAtPosition("@", Position);
        }

        public void Move()
        {
            if (Direction == Direction.Down)
            {
                Position.X++;
                if(Position.X == 41)
                {
                    Position.X = 0;
                }
            }
            if (Direction == Direction.Up)
            {
                Position.X--;
                if (Position.X == -1)
                {
                    Position.X = 40;
                }
            }

            if (Direction == Direction.Right)
            {
                Position.Y++;
                if (Position.Y == 21)
                {
                    Position.Y = 0;
                }
            }
            if (Direction == Direction.Left)
            {
                Position.Y--;
                if (Position.Y == -1)
                {
                    Position.Y = 20;
                }
            }
        }
    }
}
