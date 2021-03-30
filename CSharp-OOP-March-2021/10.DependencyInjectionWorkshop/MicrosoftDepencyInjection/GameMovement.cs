using MicrosoftDepencyInjection.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDepencyInjection
{
    class GameMovement : IGameMovement
    {
        private ILogger logger;
        public GameMovement(ILogger logger)
        {
            this.logger = logger;
        }

        public void Move()
        {
            logger.Log("Game moved!!!");
        }
    }
}
