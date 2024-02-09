

int n =int.Parse(Console.ReadLine());

SortedSet<string> names = new SortedSet<string>();

for (int i = 0; i < n; i++)
{
    names.Add(Console.ReadLine());
}

Console.WriteLine(String.Join("\n", names));