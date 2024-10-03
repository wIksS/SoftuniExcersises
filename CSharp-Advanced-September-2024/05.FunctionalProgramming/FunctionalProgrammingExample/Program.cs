// read n
// generate numbers 1 to n
// multiply all numbers by 5

Console.WriteLine(
    String.Join(",", 
    MultiplyNumbers(GenerateArray(ReadNumber()), 0, 
        ReadNumber())));

//impure
int ReadNumber()
{
    return int.Parse(Console.ReadLine());   
}

int[] GenerateArray(int n)
{
    return Enumerable.Range(1,n).ToArray();
}

int[] MultiplyNumbers(int[] numbers, int index, int multiplyAmount)
{
    if(numbers.Length == index)
    {
        return numbers;
    }

    numbers[index] *= multiplyAmount;

    return MultiplyNumbers(numbers, index + 1, multiplyAmount);
}