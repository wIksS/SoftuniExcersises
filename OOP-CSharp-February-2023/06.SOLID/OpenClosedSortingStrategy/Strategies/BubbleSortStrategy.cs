using OpenClosedSortingStrategy.Strategies;

public class BubbleSortStrategy : ISortingStrategy
{
    public List<T> Sort<T>(List<T> list)
    {
        Console.WriteLine("Bubble sorting");

        return list;
    }
}