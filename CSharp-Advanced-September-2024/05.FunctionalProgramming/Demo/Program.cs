

int[] array =new int[] {1,2,5,7,8};

array = array.Where(IsEven).ToArray();

Console.WriteLine(String.Join(",", array));


bool IsEven(int n)
{
    Console.WriteLine($"Checking {n}%2={n % 2}");
    return n % 2 == 0;
}