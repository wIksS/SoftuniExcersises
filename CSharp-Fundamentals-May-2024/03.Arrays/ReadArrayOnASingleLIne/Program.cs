string numberAsString = "5b";
int number = int.Parse(numberAsString);

//Console.WriteLine(number +5);
// 1 2 5 55 10555 34

string input = Console.ReadLine();

string[] splitted = input.Split(" ");

int[] numbers = new int[splitted.Length];

for (int i = 0; i < splitted.Length; i++)
{
    numbers[i] = int.Parse(splitted[i]);
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}