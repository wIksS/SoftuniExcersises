using InheritanceLecture.Conctract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InheritanceLecture
{
    class Engine
    {
        private IRenderer renderer;
        private List<GameObject> drawableObjects = new List<GameObject>();
        private List<IMoveable> movableObjects = new List<IMoveable>();

        public Engine(IRenderer renderer)
        {
            this.renderer = renderer;
            List<Ball> balls = new List<Ball>()
            {
                new Ball(new Position(5, 6), Direction.Right, renderer),
                new Ball(new Position(3, 6), Direction.Left, renderer),
                new Ball(new Position(4, 16), Direction.Down, renderer),
                new Ball(new Position(9, 6), Direction.Up, renderer),
                new Ball(new Position(7, 16), Direction.Right, renderer)
            };
            foreach (var ball in balls)
            {
                drawableObjects.Add(ball);
                movableObjects.Add(ball);
            }

            drawableObjects.Add(new Racket(5, new Position(2, 3), renderer));
            drawableObjects.Add(new Racket(5, new Position(2, 30), renderer));
        }

        public void Start()
        {
            while (true)
            {
                foreach (var gameObject in drawableObjects)
                {
                    gameObject.Draw();
                }

                foreach (var movableObject in movableObjects)
                {
                    movableObject.Move();
                }

                Thread.Sleep(100);
                renderer.Clear();
            }

        }
    }
}
