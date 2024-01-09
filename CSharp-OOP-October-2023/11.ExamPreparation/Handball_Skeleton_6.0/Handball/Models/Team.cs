using Handball.Models.Contracts;
using Handball.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Models
{
    public class Team : ITeam
    {
        public Team(string name)
        {
            Name = name;
            players = new List<IPlayer>();
        }

        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.TeamNameNull);
                }

                name = value;
            }
        }

        private int pointsEarned;

        public int PointsEarned
        {
            get { return pointsEarned; }
            private set { pointsEarned = value; }
        }


        public double OverallRating
        {
            get
            {
                if (players.Count == 0)
                {
                    return 0;
                }

                return Math.Round(players.Average(p => p.Rating), 2);
            }
        }


        private List<IPlayer> players;



        public IReadOnlyCollection<IPlayer> Players
        {
            get { return players.AsReadOnly(); }
        }


        public void Draw()
        {
            PointsEarned += 1;

            IPlayer goalKeeper = players.FirstOrDefault(p=> p is Goalkeeper);

            if (goalKeeper != null)
            {
                goalKeeper.IncreaseRating();
            }
        }

        public void Lose()
        {
            foreach (var player in players)
            {
                player.DecreaseRating();
            }
        }

        public void SignContract(IPlayer player)
        {
            players.Add(player);
        }

        public void Win()
        {
            PointsEarned += 3;

            foreach (var player in players)
            {
                player.IncreaseRating();
            }
        }

        public override string ToString()
        {
            string playersToString = "none";

            if (players.Count > 0)
            {
                playersToString = String.Join(", ", players.Select(p => p.Name));
            }
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Team: {Name} Points: {PointsEarned}");
            result.AppendLine($"--Overall rating: { OverallRating}");
            result.AppendLine($"--Players: {playersToString}");

            return result.ToString().Trim();
        }
    }
}
