

int[] array = Enumerable.Range(4, 10).ToArray();


array = array.Where((int n, int i) =>
{
    Console.WriteLine($"Checking index:{i} {n}%2={n % 2}");
    return n % 2 == 0;
}).ToArray();
//array = array.Where(IsEven).ToArray();

Console.WriteLine(String.Join(",", array));

bool IsEven(int n)
{
    Console.WriteLine($"Checking {n}%2={n % 2}");
    return n % 2 == 0;
}