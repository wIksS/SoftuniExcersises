

int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < n; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

//3
//10
//20
//30
// 2 1 0
for (int i = 0; i < n; i++)
{
    Console.Write(numbers[numbers.Length-1-i] + " ");
}