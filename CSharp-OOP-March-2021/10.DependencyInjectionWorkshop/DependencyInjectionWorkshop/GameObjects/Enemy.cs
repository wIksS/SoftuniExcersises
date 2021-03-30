using DependencyInjectionWorkshop.Common;
using DependencyInjectionWorkshop.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWorkshop.GameObjects
{
    class Enemy : IGameObject
    {
        private IDrawer drawer;
        public Enemy(IDrawer drawer)
        {
            Random rand = new Random();
            this.drawer = drawer;
            this.Position = new Position(rand.Next(0, 20), rand.Next(0, 20));
        }

        public Position Position { get; set; }

        public void Draw()
        {
            drawer.DrawAtPosition(Position, "E");
        }
    }
}
