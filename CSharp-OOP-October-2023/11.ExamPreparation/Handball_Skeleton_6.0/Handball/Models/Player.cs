using Handball.Models.Contracts;
using Handball.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Models
{
    public abstract class Player : IPlayer
    {
        public Player(string name, double rating)
        {
            Name = name;
            Rating = rating;
        }

        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.PlayerNameNull);
                }

                name = value;
            }
        }

        private double rating;

        public double Rating
        {
            get { return rating; }
            protected set
            {
                if (value > 10)
                {
                    rating= 10;
                    return;
                }
                else if(value < 1)
                {
                    rating = 1;
                    return;
                }

                rating = value;
            }
        }

        private string team;

        public string Team
        {
            get { return team; }
        }


        public abstract void DecreaseRating();

        public abstract void IncreaseRating();

        public void JoinTeam(string name)
        {
            team = name;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{this.GetType().Name}: {Name}");
            result.AppendLine($"--Rating: {Rating}");
            return result.ToString().Trim();
        }
    }
}
