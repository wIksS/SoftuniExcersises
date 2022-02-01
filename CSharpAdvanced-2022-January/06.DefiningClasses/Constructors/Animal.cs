using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    public class Animal
    {
        public Animal(string name, string species, string gender, bool isHungry): this(name,species,gender)
        {
            IsHungry = isHungry;
        }

        public Animal(string name, string species, string gender) : this(name, species)
        {
            Gender = gender;
        }

        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public string Species { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public bool IsHungry { get; set; }
    }
}
