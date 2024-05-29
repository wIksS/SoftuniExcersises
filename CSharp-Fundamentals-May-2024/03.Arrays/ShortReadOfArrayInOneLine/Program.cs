

//string input = Console.ReadLine();

//string[] splitted = input.Split(" ");

//int[] numbers = splitted.Select(int.Parse).ToArray();



int[] numbersInOneLine = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

for (int i = 0; i < numbersInOneLine.Length; i++)
{
    Console.Write(numbersInOneLine[i] + " ");
}
