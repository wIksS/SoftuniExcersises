using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;

            Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public bool HasElement(string element)
        {
            return Pokemons.Any(p => p.Element == element);
        }

        public void Loose()
        {
            foreach (var pokemon in Pokemons)
            {
                pokemon.Health -= 10;
            }

            Pokemons = Pokemons.Where(p => p.Health > 0).ToList();
        }

        public override string ToString()
        {
            return $"{Name} {NumberOfBadges} {Pokemons.Count}";
        }
    }
}
