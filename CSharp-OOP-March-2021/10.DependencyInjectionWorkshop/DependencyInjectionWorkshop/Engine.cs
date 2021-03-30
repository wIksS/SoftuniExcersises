using Autofac;
using DependencyInjectionWorkshop.Common;
using DependencyInjectionWorkshop.Contracts;
using DependencyInjectionWorkshop.DI.Attributes;
using DependencyInjectionWorkshop.GameObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DependencyInjectionWorkshop
{
    class Engine
    {
        private ILogger logger;
        private IReader reader;
        private List<IGameObject> gameObjects;
        private List<IGameObject> enemies;
        private Ball ball;
        private IMover mover;
        public Engine(ILogger logger, IReader reader, IMover mover)
        {
            this.mover = mover;
            this.logger = logger;
            this.reader = reader;
            gameObjects = new List<IGameObject>();
            enemies = new List<IGameObject>();
            ball = InjectorSingleton.Instance.Resolve<Ball>();
            gameObjects.Add(ball);
            enemies.Add(InjectorSingleton.Instance.Resolve<Enemy>());
        }

        public void Start()
        {

            while (true)
            {
                foreach (var gameObject in gameObjects)
                {
                    gameObject.Draw();
                }

                foreach (var gameObject in enemies)
                {
                    gameObject.Draw();
                    mover.Move(gameObject, new Position(1, 0));
                }

                Position position = reader.ReadKey();

                mover.Move(ball, position);


                Thread.Sleep(100);
                Console.Clear();
            }
        }


        public void End()
        {
            logger.Log("Game Ended");
        }
    }
}
