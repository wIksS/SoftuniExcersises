

int n = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine().Split().ToArray();

Func<string, bool> lenghtFilter = s => s.Length <= n;

string[] filteredNames = names.Where(lenghtFilter).ToArray();

foreach (string name in filteredNames)
{
    Console.WriteLine(name);
}