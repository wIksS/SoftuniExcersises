

using Threeuples;

string[] input = Console.ReadLine().Split();

string name = $"{input[0]} {input[1]}";
string town = "";
//Adam Smith Wallstreet New York State of Mass

//for (int i = 3; i < input.Length; i++)
//{
//    town += input[i] + " ";
//}

//town = town.Trim();

Threeuple<string, string, string> threeuple = new Threeuple<string, string, string>(
    name, input[2], String.Join(" ", input[3..]));

Console.WriteLine(threeuple);

//Mark 18 drunk
input = Console.ReadLine().Split();

bool isDrunk = false;
if (input[2] == "drunk") isDrunk = true;

Threeuple<string, int, bool> beer = new Threeuple<string, int, bool>(
    input[0], int.Parse(input[1]), isDrunk);

Console.WriteLine(beer);

input = Console.ReadLine().Split();


Threeuple<string, double, string> bank = new Threeuple<string, double, string>(
    input[0], double.Parse(input[1]), input[2]);

Console.WriteLine(bank);