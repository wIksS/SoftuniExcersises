
Func<int, bool> isEven = IsEven;
Func<int> readNumber = ReadNumber;
Func<int, int[]> generateArray = GenerateArray;
Func<int[], int, int, int[]> multiplyNumber = MultiplyNumbers;


bool IsEven(int n)
{
    return n % 2 == 0;
}

int ReadNumber()
{
    return int.Parse(Console.ReadLine());
}
int[] GenerateArray(int n)
{
    return Enumerable.Range(1, n).ToArray();
}

int[] MultiplyNumbers(int[] numbers, int index, int multiplyAmount)
{
    if (numbers.Length == index)
    {
        return numbers;
    }

    numbers[index] *= multiplyAmount;

    return MultiplyNumbers(numbers, index + 1, multiplyAmount);
}