using FootballManager.Models.Contracts;
using FootballManager.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public abstract class Manager : IManager
    {
        private string name;
        private double ranking;

        protected Manager(string name, double ranking)
        {
            Name = name;
            Ranking = ranking;
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
                    throw new ArgumentException(ExceptionMessages.ManagerNameNull);
                }

                name = value;
            }
        }

        public double Ranking
        {
            get
            {
                return ranking;
            }
            protected set
            {
                ranking = value;
            }
        }

        public abstract void RankingUpdate(double updateValue);

        public override string ToString()
        {
            string managerType = this.GetType().Name;

            return $"{Name} - {managerType} (Ranking: {Ranking:F2})";
        }

        protected void UpdateRanking(double updateValue)
        {
            if (Ranking + updateValue > 100)
            {
                Ranking = 100;
                return;
            }
            else if (Ranking + updateValue < 0)
            {
                Ranking = 0;
                return;
            }

            Ranking += updateValue;
        }
    }
}
