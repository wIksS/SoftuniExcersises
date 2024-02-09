
using System.Collections;

StreamReader reader;

UseStream(new List<int>());
//Constraint

void UseStream<T>(T parameter) where T : IEnumerable 
{
    Console.WriteLine(parameter);
}