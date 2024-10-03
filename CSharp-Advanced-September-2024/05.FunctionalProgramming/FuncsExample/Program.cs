
Func<string,int> parser = int.Parse;

int[] numbers = 
    Console.ReadLine().Split(", ")
    .Select(parser)
    .ToArray();

Console.WriteLine(numbers.Length);
Console.WriteLine(numbers.Sum());

//delegate int Parser(string n);