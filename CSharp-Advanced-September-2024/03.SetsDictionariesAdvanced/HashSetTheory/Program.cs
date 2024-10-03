HashSet<int> set = new HashSet<int>();

set.Add(1);
set.Add(1);
set.Add(1);
set.Add(1);
set.Add(1);
set.Add(2);


foreach (int number in set)
{
    Console.WriteLine(number);
}

Console.WriteLine(set.Contains(1));

Console.WriteLine(set.Remove(1));

HashMap = HashSet