
int[] array = new int []{ 1, 22, 3, 4,41,32,44,55,1,2,3,5 };
Console.WriteLine(Sum(array));


int Sum(int[] array, int index = 0)
{
    if (index >= array.Length)
    {
        Console.WriteLine("In the base case");
        return 0;
    }

    Console.WriteLine($"Before recursion index={index}");

    int sum = array[index] + Sum(array, index + 1);

    Console.WriteLine($"After recursion index={index}");

    return sum;
}