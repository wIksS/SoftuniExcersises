

int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"numbers[{i}]=");
    numbers[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}