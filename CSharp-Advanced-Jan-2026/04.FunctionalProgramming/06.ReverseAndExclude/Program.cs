

int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = int.Parse(Console.ReadLine());

Func<int, int, bool> isNDivisibleFunc = (x,n) => x % n == 0;

int[] divisible = array.Where(x => !isNDivisibleFunc(x, n)).Reverse().ToArray();

Console.WriteLine(String.Join(" ", divisible));

bool IsNDivisible(int number, int n)
{
    return number % n == 0;
}