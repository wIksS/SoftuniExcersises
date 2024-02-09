
IEnumerator<int> enumerator = GenerateNumbers();
//Console.WriteLine($"Current: {enumerator.Current}");

//Console.WriteLine(enumerator.MoveNext());
//Console.WriteLine($"Current: {enumerator.Current}");

//Console.WriteLine(enumerator.MoveNext());
//Console.WriteLine($"Current: {enumerator.Current}");

//Console.WriteLine(enumerator.MoveNext());
//Console.WriteLine($"Current: {enumerator.Current}");

//Console.WriteLine(enumerator.MoveNext());
//Console.WriteLine($"Current: {enumerator.Current}");

//Console.WriteLine(enumerator.MoveNext());


IEnumerator<int> GenerateNumbers()
{
    Console.WriteLine("Before yield 5");
    yield return 5;
    Console.WriteLine("After yield 5");

    Console.WriteLine("Before yield 6");
    yield return 6;
    Console.WriteLine("After yield 6");

    Console.WriteLine("Before yield 7");
    yield return 7;
    Console.WriteLine("After yield 7");
}