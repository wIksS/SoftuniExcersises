

using SoftUniHashSetNS;
using System.Diagnostics;

//SoftUniHashSet set = new SoftUniHashSet();

//set.Add("ABA");

//set.Add("GOSHO");

//set.Add("AAB");

//set.Add("DIMI"); 


//for (int i = 0; i < 10000; i++)
//{
//    set.Add($"DIMI{i}");
//}

//Console.WriteLine();


//Console.WriteLine(set.Contains("DIMI9951"));
//Console.WriteLine(set.Contains("DIMI9999"));
//Console.WriteLine(set.Contains("DIMI10000"));




int n = 50000;
int operations = 5000000;




SoftUniHashSet softuni = new SoftUniHashSet();

for (int i = 0; i < n; i++)
{
    softuni.Add($"element{i}");
}

Stopwatch watch = Stopwatch.StartNew();

for (int i = 0; i < operations; i++)
{
    softuni.Contains($"element{i}");
}

Console.WriteLine($"softuni hashset: {watch.ElapsedMilliseconds}");


HashSet<string> hashSet = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    hashSet.Add($"element{i}");
}

watch = Stopwatch.StartNew();

for (int i = 0; i < operations; i++)
{
    hashSet.Contains($"element{i}");
}

Console.WriteLine($"C# hashset: {watch.ElapsedMilliseconds}");

List<string> list = new List<string>();

for (int i = 0; i < n; i++)
{
    list.Add($"element{i}");
}

 watch = Stopwatch.StartNew();

for (int i = 0; i < operations; i++)
{
    list.Contains($"element{i}");
}

Console.WriteLine($"List: {watch.ElapsedMilliseconds}");