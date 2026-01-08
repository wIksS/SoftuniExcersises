

int[] pairArray = new int[2] { 1, 2 };

Tuple<int, int> pair = new Tuple<int, int>(1, 2);

Console.WriteLine(pair.Item1);
Console.WriteLine(pair.Item2);

Tuple<int, string, int> elements = new Tuple<int, string, int>(20, "Pesho", 6);

string name = elements.Item2;

KeyValuePair<string, int> personAge = new KeyValuePair<string, int>("Pesho", 13);

Console.WriteLine(personAge.Key);
Console.WriteLine(personAge.Value);

(int, string) tuple = (5, "hey");

