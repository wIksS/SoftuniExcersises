
List<int> list =Console.ReadLine().Split().Select(int.Parse).ToList();


Console.WriteLine(RecursiveSum(list,0));

int RecursiveSum(List<int> list, int index)
{
    if (list.Count-1 == index)
    {
        return list[index];
    }

    // pre-actions
    //Console.WriteLine("Before recursion");
    // recursion
    int sumOfRestElements = RecursiveSum(list, index + 1);

    //post-actions
    //Console.WriteLine("After recursion");
    int sumOfAllElements = list[index] + sumOfRestElements;

    return sumOfAllElements;

    // return list[index] + RecursiveSum(list, index+1);
}