

var list = new List<int>() { 5, 1, 3, 15, 12, -5, 4 };

var evenList = list.Where((int x, int index) =>
{
    Console.WriteLine($"list[{index}]={x}");
    return x % 2 == 0;
});
var evenList2 = list.Where((int x, int index) => x % 2 == 0);
//var evenList = list
//    .Where(IsEven);

Console.WriteLine(String.Join(" ", evenList));

//static bool IsEven(int x, int index)
//{
//    Console.WriteLine($"list[{index}]={x}");
//    if (x % 2 == 0)
//        return true;
//    return false;
//}