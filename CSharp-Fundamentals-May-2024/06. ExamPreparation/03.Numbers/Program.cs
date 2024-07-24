

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); 

List<int> greaterThanAverageNumbers = new List<int>();

int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}

int average = (int)numbers.Sum() / numbers.Length;

//Console.WriteLine(average);

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > average)
    {
        greaterThanAverageNumbers.Add(numbers[i]);
    }
}

greaterThanAverageNumbers.Sort();
greaterThanAverageNumbers.Reverse();

if (greaterThanAverageNumbers.Count == 0)
{
    Console.WriteLine("No");
}
else
{
    int count = greaterThanAverageNumbers.Count;
    if (count > 5)
    {
        count = 5;
    }
    for (int i = 0; i < count; i++)
    {
        //if (i >= 5)
        //{
        //    break;
        //}

        Console.Write(greaterThanAverageNumbers[i] + " ");

    }
}