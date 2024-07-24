using System.Text;

string input = Console.ReadLine();
string message = input;

string command = Console.ReadLine();

while (command != "Decode")
{
    string[] splittedInput = command.Split('|');
    string currentCommand = splittedInput[0];

    if (currentCommand == "ChangeAll")
    {
        string oldValue = splittedInput[1];
        string newValue = splittedInput[2];

        message = message.Replace(oldValue, newValue);
    }
    else if (currentCommand == "Insert")
    {
        int index = int.Parse(splittedInput[1]);
        string value = splittedInput[2];
        message = message.Insert(index, value);
    }
    else if (currentCommand == "Move")
    {
        int n = int.Parse(splittedInput[1]);

        for (int i = 0; i < n; i++)
        {
            char firstChar = message[0];

            message += firstChar;

            message = message.Remove(0, 1);
        }
    }

    // Console.WriteLine(message);
    command = Console.ReadLine();
}

Console.WriteLine($"The decrypted message is: {message}");