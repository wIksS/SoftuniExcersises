List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();// new List<int>() { 5, 1, 7, 3, 4, 2 };

//List<int> left = new List<int>() { 1,3,6 };
//List<int> right = new List<int>() { 2, 4, 5,6,7 };
//Console.WriteLine(String.Join(",",MergeTwoSortedLists(left,new List<int>())));

Console.WriteLine(String.Join(" ", MergeSort(list,0,list.Count)));

List<int> MergeSort(List<int> list, int start, int end)
{
    if (end - start == 1)
    {
        return new List<int>() { list[start] };
    }
    if(end- start <= 0)
    {
        return new List<int>();
    }

    int middle = (start + end) / 2;

    List<int> sortedLeftPart = MergeSort(list, start, middle);
    List<int> sortedRightPart = MergeSort(list, middle, end);
    //if (sortedLeftPart!= null)
    //    Console.WriteLine(string.Join(",", sortedLeftPart));
    //if (sortedRightPart != null)
    //    Console.WriteLine(string.Join(",", sortedRightPart));

    return MergeTwoSortedLists(sortedLeftPart, sortedRightPart);
}

List<int> MergeTwoSortedLists(List<int> left, List<int> right)
{
    List<int> mergedList = new List<int>();
    int leftIndex = 0;
    int rightIndex = 0;

    for (int i = 0; i < left.Count + right.Count; i++)
    {
        if (leftIndex >= left.Count)
        {
            mergedList.Add(right[rightIndex++]);
            continue;
        }
        else if (rightIndex >= right.Count)
        {
            mergedList.Add(left[leftIndex++]);
            continue;
        }

        if (left[leftIndex] <= right[rightIndex])
        {
            mergedList.Add(left[leftIndex++]);
        }
        else
        {
            mergedList.Add(right[rightIndex++]);
        }
    }

    return mergedList;
}