int[] numbers = 
    Console.ReadLine().Split(", ")
    .Select(int.Parse)// map
    .Where(x=>x% 2==0)
    .OrderBy(x=>x)
    .ToArray();

Console.WriteLine(String.Join(", ", numbers));

//static int SortBy(int x)
//{
//    return x;
//}