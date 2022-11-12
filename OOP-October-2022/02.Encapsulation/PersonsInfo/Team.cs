using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();   
            this.name = name;
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get
            {
                return firstTeam.AsReadOnly();
            }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get
            {
                return reserveTeam.AsReadOnly();
            }
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player); 
            }
        }

        public override string ToString()
        {
            return $"First team has {firstTeam.Count} players." + Environment.NewLine +
                    $"Reserve team has {reserveTeam.Count} players.";
        }
    }
}
