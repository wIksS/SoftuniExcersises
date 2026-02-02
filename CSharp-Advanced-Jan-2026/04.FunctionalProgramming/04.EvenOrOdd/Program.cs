string[] input = Console.ReadLine().Split();
int start = int.Parse(input[0]);
int end = int.Parse(input[1]);  
string filterType = Console.ReadLine();

Predicate<int> filter;

if (filterType == "odd")
{
    //filter = x => x % 2 == 1;
    filter = IsOdd;
}
else
{
    filter = x => x % 2 == 0;
}

//10 15
int[] array = Enumerable.Range(start, end - start + 1).ToArray();
array = array.Where(x => filter(x)).ToArray();

string result = string.Join(" ", array).Trim();
Console.WriteLine(result);

bool IsOdd(int x)
{
    return Math.Abs(x % 2) == 1;
}