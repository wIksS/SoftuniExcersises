Predicate<string> checker = n => n[0] == n.ToUpper()[0];
//Func<string,bool> checker = n => n[0] == n.ToUpper()[0];

string[] words = Console.ReadLine()
       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
       .Where(w => checker(w))
       .ToArray();
foreach (string word in words)
{
    Console.WriteLine(word);
}
