
string input = Console.ReadLine();  

int n = int.Parse(Console.ReadLine());

string result = GenerateRepeatedString(input, n);

Console.WriteLine(result);

string GenerateRepeatedString(string input, int n)
{
    string result = "";

    for (int i = 0; i < n; i++)
    {
        result += input;
    }

    return result;
}