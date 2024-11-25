using FootballManager.Models.Contracts;
using FootballManager.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class Team : ITeam
    {
        private string name;
        private int championshipPoints;
        private IManager teamManager;

        public Team(string name)
        {
            Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.TeamNameNull);
                }

                name = value;
            }
        }

        public int ChampionshipPoints
        {
            get
            {
                return championshipPoints;
            }
            private set
            {
                championshipPoints = value;
            }
        }

        public IManager TeamManager
        {
            get
            {
                return teamManager;
            }
            private set
            {
                teamManager = value;
            }
        }
        public int PresentCondition
        {
            get
            {
                if (TeamManager == null)
                {
                    return 0;
                }
                if (championshipPoints == 0)
                {
                    return (int)TeamManager.Ranking;
                }
                int condition =(int)(ChampionshipPoints * TeamManager.Ranking);

                return condition;
            }
        }

        public void GainPoints(int points)
        {
            ChampionshipPoints += points;
        }

        public void ResetPoints()
        {
            ChampionshipPoints = 0;
        }

        public void SignWith(IManager manager)
        {
            TeamManager = manager;
        }

        public override string ToString()
        {
            return $"Team: {Name} Points: {ChampionshipPoints}";
        }
    }
}
