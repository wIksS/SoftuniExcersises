

using System.Numerics;

int n = int.Parse(Console.ReadLine());
BigInteger factorial = 1;

for (int i = 1; i <= n; i++)
{
    factorial *= i;
}

Console.WriteLine(factorial);

