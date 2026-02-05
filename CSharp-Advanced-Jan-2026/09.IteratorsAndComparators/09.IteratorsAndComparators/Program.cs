


using _09.IteratorsAndComparators;

//Softuni softuni = new Softuni();

//foreach (var course in softuni)
//{
//    Console.WriteLine(course);
//}

//List<int> list = [1, 2, 3, 4, 5];

//ListyIterator<int> iterator = new ListyIterator<int>(list);

//while (iterator.MoveNext())
//{
//    Console.WriteLine(iterator.Current);
//}

string command = Console.ReadLine();
ListyIterator<string> iterator = null;

while (command != "END")
{
    string[] input = command.Split();
    if (input[0] == "Create")
    {
        List<string> elements = input[1..].ToList();
        iterator = new ListyIterator<string>(elements);
    }
    if (input[0] == "Move")
    {
        Console.WriteLine(iterator.MoveNext());
    }
    if (input[0] == "HasNext")
    {
        Console.WriteLine(iterator.HasNext());

    }
    if (input[0] == "PrintAll")
    {
        foreach (var item in iterator)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
    }
    if (input[0] == "Print")
    {
        try
        {
            Console.WriteLine(iterator.Current);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    command = Console.ReadLine();
}