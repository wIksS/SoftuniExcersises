

using System.Collections;

int[] array = new int[50];

new Printer().PrintCollection<int[]>(array);

class Printer
{
    public void PrintCollection<T>(T collection) where T : ICollection
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }
}