using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public abstract class Diver : IDiver
    {
        private string name;
        private int oxygenLevel;
        private List<string> caughtFish;
        private double competitionPoints;
        private bool hasHealthIssues;

        public Diver(string name, int oxygenLevel)
        {
            this.Name = name;
            this.OxygenLevel = oxygenLevel;
            caughtFish = new List<string>();
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
                    throw new ArgumentException(ExceptionMessages.DiversNameNull);
                }

                this.name = value;
            }
        }


        public int OxygenLevel
        {
            get { return oxygenLevel; }
            protected set
            {
                if (value <= 0)
                {
                    hasHealthIssues = true;
                    oxygenLevel = 0;
                }
                else
                {
                    oxygenLevel = value;
                }
            }
        }


        public IReadOnlyCollection<string> Catch
        {
            get { return caughtFish.AsReadOnly(); }
        }

        public double CompetitionPoints
        {
            get { return competitionPoints; }
        }

        public bool HasHealthIssues
        {
            get { return hasHealthIssues; }
            private set { hasHealthIssues = value; }
        }


        public void Hit(IFish fish)
        {
            OxygenLevel -= fish.TimeToCatch;
            this.caughtFish.Add(fish.Name);
            competitionPoints = Math.Round(competitionPoints + fish.Points,1);
        }

        public abstract void Miss(int TimeToCatch);

        public abstract void RenewOxy();

        public void UpdateHealthStatus()
        {
            HasHealthIssues = !HasHealthIssues;
        }

        public override string ToString()
        {
            return $"Diver [ Name: {Name}, Oxygen left: {OxygenLevel}, Fish caught: {caughtFish.Count}, Points earned: {CompetitionPoints} ]";
        }
    }
}
