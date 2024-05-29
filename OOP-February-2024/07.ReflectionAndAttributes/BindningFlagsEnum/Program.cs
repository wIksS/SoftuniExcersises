using System.Reflection;

Console.WriteLine((int)BindingFlags.Public); 
Console.WriteLine((int)BindingFlags.NonPublic);
Console.WriteLine((int)BindingFlags.Instance);
Console.WriteLine((int)BindingFlags.Static);

Console.WriteLine(16 | 32 | 4 | 8);