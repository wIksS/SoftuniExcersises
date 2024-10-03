

Predicate<string> stringFilter = IsHello;//n => n.ToLower() == "hello";
//Func<string,bool>
Console.WriteLine(stringFilter("HELLO"));
Console.WriteLine(stringFilter("test"));

bool IsHello(string input)
{
    return input.ToLower() == "hello";
}