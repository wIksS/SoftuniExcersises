
using Prototype;

User user = new User() { Name = "Dimitrichko" };
Dice d6 = new Dice();

d6.Thrown = 6;
d6.Sides = 4;
d6.Thrower = user;

Dice clonedD6 = (Dice)d6.Clone();

d6.Thrown = 50;

d6.Thrower.Name = "Nedimitrichko";

Console.WriteLine($"{clonedD6.Thrower.Name} has thrown {clonedD6.Thrown}");