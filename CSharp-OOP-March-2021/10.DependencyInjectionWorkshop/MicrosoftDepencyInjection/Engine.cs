using MicrosoftDepencyInjection.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDepencyInjection
{
    class Engine
    {
        private ILogger logger;
        private IGameMovement movement;

        public Engine(ILogger logger, IGameMovement movement)
        {
            this.logger = logger;
            this.movement = movement;
        }

        public void Start()
        {
            logger.Log("Game Started");
            movement.Move();
        }


        public void End()
        {
            logger.Log("Game Ended");
        }
    }
}
