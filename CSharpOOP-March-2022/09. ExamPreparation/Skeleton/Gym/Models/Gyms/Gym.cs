using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;

        public Gym(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Athletes = new List<IAthlete>();
            Equipment = new List<IEquipment>();
        }

        public string Name
        {
            get
            {

                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGymName);
                }
                this.name = value;
            }
        }

        public int Capacity { get; private set; }


        public double EquipmentWeight
        {
            get { return this.Equipment.Select(e => e.Weight).Sum(); }
        }

        public ICollection<IEquipment> Equipment { get; }

        public ICollection<IAthlete> Athletes { get; }


        public void AddAthlete(IAthlete athlete)
        {
            if (Athletes.Count >= Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughSize);
            }

            this.Athletes.Add(athlete);

        }

        public void AddEquipment(IEquipment equipment)
        {
            Equipment.Add(equipment);
        }

        public void Exercise()
        {
            foreach (var athlete in Athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{Name} is a {this.GetType().Name}:");

            string athletes;
            if (Athletes.Count > 0 )
            {
                athletes = String.Join(", ", Athletes.Select(a => a.FullName));
            }
            else
            {
                athletes = "No athletes";
            }

            result.AppendLine($"Athletes: {athletes}");

            result.AppendLine($"Equipment total count: {Equipment.Count}");
            result.AppendLine($"Equipment total weight: { EquipmentWeight:f2} grams");

            return result.ToString().TrimEnd();
        }

        public bool RemoveAthlete(IAthlete athlete)
        {
            return Athletes.Remove(athlete);
        }
    }
}
