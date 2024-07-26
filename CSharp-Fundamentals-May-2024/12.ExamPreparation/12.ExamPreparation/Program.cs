using System.Text;

string input = Console.ReadLine();

string command = Console.ReadLine();

StringBuilder result = new StringBuilder(input);


while (command != "Travel")
{
    string[] splittedInput = command.Split(':');

    if (splittedInput[0].Contains("Add"))
    {
        int index = int.Parse(splittedInput[1]);
        string stringToAdd = splittedInput[2];

        if (IsIndexValid(index, result.Length))
        {
            result.Insert(index, stringToAdd);
        }
    }
    else if (splittedInput[0].Contains("Remove"))
    {
        int startIndex = int.Parse(splittedInput[1]);
        int endIndex = int.Parse(splittedInput[2]);

        if (IsIndexValid(startIndex, result.Length) && IsIndexValid(endIndex, result.Length) && startIndex <= endIndex && endIndex < result.Length)
        {
            result.Remove(startIndex, endIndex - startIndex + 1);
        }
    }
    else if (splittedInput[0].Contains("Switch"))
    {
        string oldValue = splittedInput[1];
        string newValue = splittedInput[2];

        result.Replace(oldValue, newValue);
    }

    Console.WriteLine(result);

    command = Console.ReadLine();
}

Console.WriteLine($"Ready for world tour! Planned stops: {result}");

bool IsIndexValid(int index, int length)
{
    if (index >= 0 && index <= length)
    {
        return true;
    }

    return false;
}