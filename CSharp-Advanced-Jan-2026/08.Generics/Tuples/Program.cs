

using System.Runtime.InteropServices;
using Tuples;


(string, int, DateTime) random = ("test", 5, DateTime.Now);



CustomTuple<string, string> nameAndAdress = new CustomTuple<string, string>();

string[] line = Console.ReadLine().Split();

nameAndAdress.Item1 = line[0] + " " +line[1];
nameAndAdress.Item2 = line[2];

Console.WriteLine(nameAndAdress);

CustomTuple<string, int> nameAndBeer = new CustomTuple<string, int>();

line = Console.ReadLine().Split();

nameAndBeer.Item1 = line[0];
nameAndBeer.Item2 = int.Parse(line[1]);

Console.WriteLine(nameAndBeer);

line = Console.ReadLine().Split();
 
CustomTuple<int, double> numbers = new CustomTuple<int, double>();

numbers.Item1 = int.Parse(line[0]);
numbers.Item2 = double.Parse(line[1]);

Console.WriteLine(numbers);