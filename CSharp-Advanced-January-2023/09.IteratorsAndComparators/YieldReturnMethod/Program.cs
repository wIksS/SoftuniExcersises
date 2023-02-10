// See http

IEnumerator<string> enumerator = IterateNames();

while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}

IEnumerator<string> IterateNames()
{
    Console.WriteLine("First");

    yield return "Pesho";

    Console.WriteLine("Second");

    yield return "Gosho";

    Console.WriteLine("Third");

    yield return "Dimitirchko";
}