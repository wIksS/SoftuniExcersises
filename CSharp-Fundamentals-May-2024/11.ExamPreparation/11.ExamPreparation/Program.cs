using System.Text;

string input = Console.ReadLine();
StringBuilder message = new StringBuilder(input);

string command = Console.ReadLine();

while (command != "Decode")
{
    string[] splittedInput = command.Split('|');
    string currentCommand = splittedInput[0];

    if (currentCommand == "ChangeAll")
    {
        string oldValue = splittedInput[1];
        string newValue = splittedInput[2];

        message.Replace(oldValue, newValue);
    }
    else if (currentCommand == "Insert")
    {
        int index = int.Parse(splittedInput[1]);
        string value = splittedInput[2];

        message.Insert(index, value);
    }
    else if (currentCommand == "Move")
    {
        int n = int.Parse(splittedInput[1]);

        string subString = message.ToString().Substring(0, n);

        message.Remove(0, n);

        message.Append(subString);

        //for (int i = 0; i < n; i++)
        //{
        //    char firstChar = message[0];

        //    message.Append(firstChar);

        //    message.Remove(0, 1);
        //}
    }

    // Console.WriteLine(message);
    command = Console.ReadLine();
}

Console.WriteLine($"The decrypted message is: {message}");