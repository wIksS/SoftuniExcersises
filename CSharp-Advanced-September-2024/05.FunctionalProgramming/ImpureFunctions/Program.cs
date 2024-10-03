int n = int.Parse(Console.ReadLine());

int[] array = Enumerable.Range(1,n).ToArray();

Console.WriteLine(CalculateNFactorial(n));

// no side effects - change of data outside of function
int CalculateNFactorial(int n)
{
    int nFact = 1;
    for (int i = 0; i < n; i++)
    {
        nFact *= array[i];
    }

    array = array.Select(i => i * 5).ToArray();

    return nFact;
}