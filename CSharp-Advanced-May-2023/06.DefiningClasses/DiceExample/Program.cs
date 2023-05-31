
using DiceExample;

Dice d6 = new Dice()
{
    side = 6,
    color = "white"
};

d6.Roll();
Console.WriteLine(d6);
Dice d1 = new Dice()
{
    side = 1,
    color = "green"
};


d1.Roll();