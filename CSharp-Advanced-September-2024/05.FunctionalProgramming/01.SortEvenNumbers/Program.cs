

int[] array = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .Where(n => n % 2 == 0)
    .OrderBy(n => n)
    .ToArray();

Console.WriteLine(String.Join(", ", array));


//int Order(int n)
//{
//    return n;
//}