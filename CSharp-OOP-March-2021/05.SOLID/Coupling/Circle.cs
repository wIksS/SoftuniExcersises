using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling
{
    public class Circle
    {
        private IWriter writer;

        public Circle(IWriter writer)
        {
            this.writer = writer;
        }

        public void Draw()
        {
            CalcuteDrawingOrbit();
            FillCircleOrbitWithStars();
            CheckCollisionWithOtherCirlces();
        }

        private void CalcuteDrawingOrbit()
        {
            // Calculated the orbit 
            // around which we will
            // draw the circle
        }

        private void FillCircleOrbitWithStars()
        {
            // fill the orbit
            // with the circle
            // using stars
        }

        private void CheckCollisionWithOtherCirlces()
        {
            // check if circle collides
            // with other circles}
        }
    }
}