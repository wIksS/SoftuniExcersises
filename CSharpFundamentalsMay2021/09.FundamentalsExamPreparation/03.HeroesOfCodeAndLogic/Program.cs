using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesOfCodeAndLogic
{
    class Hero
    {
        public int HP { get; set; }
        public int MP { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var splitted = Console.ReadLine().Split();
                string name = splitted[0];
                int hp = int.Parse(splitted[1]);
                int mp = int.Parse(splitted[2]);

                heroes.Add(name, new Hero() { HP = hp, MP = mp });
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                if (command.Contains("CastSpell"))
                {
                    var splitted = command.Split(" - ");
                    string heroName = splitted[1];
                    int mpNeeded = int.Parse(splitted[2]);
                    string spellName = splitted[3];

                    if (heroes[heroName].MP < mpNeeded)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                    else
                    {
                        heroes[heroName].MP -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].MP} MP!");
                    }
                }
                if (command.Contains("TakeDamage"))
                {
                    var splitted = command.Split(" - ");
                    string heroName = splitted[1];
                    int damage = int.Parse(splitted[2]);
                    string attacker = splitted[3];

                    if (heroes[heroName].HP <= damage)
                    {
                        heroes[heroName].HP = 0;
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                    else
                    {
                        heroes[heroName].HP -= damage;
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
                    }
                }

                if (command.Contains("Recharge"))
                {
                    var splitted = command.Split(" - ");
                    string heroName = splitted[1];
                    int amount = int.Parse(splitted[2]);

                    if (heroes[heroName].MP + amount > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - heroes[heroName].MP} MP!");
                        heroes[heroName].MP = 200;
                    }
                    else
                    {
                        heroes[heroName].MP += amount;

                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }

                if (command.Contains("Heal"))
                {
                    var splitted = command.Split(" - ");
                    string heroName = splitted[1];
                    int amount = int.Parse(splitted[2]);

                    if (heroes[heroName].HP + amount > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - heroes[heroName].HP} HP!");
                        heroes[heroName].HP = 100;
                    }
                    else
                    {
                        heroes[heroName].HP += amount;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }

                command = Console.ReadLine();

            }

            heroes = heroes
                .Where(h => h.Value.HP > 0)
                .OrderByDescending(h => h.Value.HP)
                .ThenBy(h => h.Key)
                .ToDictionary(h => h.Key, h => h.Value);

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value.HP}");
                Console.WriteLine($"  MP: {hero.Value.MP}");
            }
        }
    }
}




//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _03.HeroesOfCodeAndLogic
//{
//    class Hero
//    {
//        public int HP { get; set; }
//        public int MP { get; set; }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<string, int> heroesHP = new Dictionary<string, int>();
//            Dictionary<string, int> heroesMP = new Dictionary<string, int>();

//            int n = int.Parse(Console.ReadLine());

//            for (int i = 0; i < n; i++)
//            {
//                var splitted = Console.ReadLine().Split();
//                string name = splitted[0];
//                int hp = int.Parse(splitted[1]);
//                int mp = int.Parse(splitted[2]);

//                heroesHP.Add(name, hp);
//                heroesMP.Add(name, mp);
//            }

//            string command = Console.ReadLine();
//            while (command != "End")
//            {
//                if (command.Contains("CastSpell"))
//                {
//                    var splitted = command.Split(" - ");
//                    string heroName = splitted[1];
//                    int mpNeeded = int.Parse(splitted[2]);
//                    string spellName = splitted[3];

//                    if (heroesMP[heroName] < mpNeeded)
//                    {
//                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
//                    }
//                    else
//                    {
//                        heroesMP[heroName] -= mpNeeded;
//                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesMP[heroName]} MP!");
//                    }
//                }
//                if (command.Contains("TakeDamage"))
//                {
//                    var splitted = command.Split(" - ");
//                    string heroName = splitted[1];
//                    int damage = int.Parse(splitted[2]);
//                    string attacker = splitted[3];

//                    if (heroesHP[heroName] <= damage)
//                    {
//                        heroesHP[heroName] = 0;
//                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
//                    }
//                    else
//                    {
//                        heroesHP[heroName] -= damage;
//                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesHP[heroName]} HP left!");
//                    }
//                }

//                if (command.Contains("Recharge"))
//                {
//                    var splitted = command.Split(" - ");
//                    string heroName = splitted[1];
//                    int amount = int.Parse(splitted[2]);

//                    if (heroesMP[heroName] + amount > 200)
//                    {
//                        Console.WriteLine($"{heroName} recharged for {200 - heroesMP[heroName]} MP!");
//                        heroesMP[heroName] = 200;
//                    }
//                    else
//                    {
//                        heroesMP[heroName] += amount;

//                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
//                    }
//                }

//                if (command.Contains("Heal"))
//                {
//                    var splitted = command.Split(" - ");
//                    string heroName = splitted[1];
//                    int amount = int.Parse(splitted[2]);

//                    if (heroesHP[heroName] + amount > 100)
//                    {
//                        Console.WriteLine($"{heroName} healed for {100 - heroesHP[heroName]} HP!");
//                        heroesHP[heroName] = 100;
//                    }
//                    else
//                    {
//                        heroesHP[heroName] += amount;
//                        Console.WriteLine($"{heroName} healed for {amount} HP!");
//                    }
//                }

//                command = Console.ReadLine();

//            }

//            heroesHP = heroesHP
//                .Where(h => h.Value > 0)
//                .OrderByDescending(h => h.Value)
//                .ThenBy(h => h.Key)
//                .ToDictionary(h => h.Key, h => h.Value);

//            foreach (var hero in heroesHP)
//            {
//                Console.WriteLine(hero.Key);
//                Console.WriteLine($"  HP: {hero.Value}");
//                Console.WriteLine($"  MP: {heroesMP[hero.Key]}");
//            }
//        }
//    }
//}