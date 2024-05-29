int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i*5;
}


for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}