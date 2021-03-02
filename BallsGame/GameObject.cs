using InheritanceLecture.Conctract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture
{
    abstract class GameObject
    {
        protected IRenderer Renderer { get; set; }

        public Position Position { get; set; }
        
        public GameObject(Position startingPosition, IRenderer renderer)
        {
            Position = startingPosition;
            Renderer = renderer;
        }

        public abstract void Draw();
    }
}
