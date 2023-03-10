

int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

int number = int.Parse(Console.ReadLine());

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        Console.WriteLine(i);
        break;
    }
}

// 1 + n + n + n + 1 = 3n + 2

// n - where n is size of array

// 1 - best case
// n - average case
// n - worst case