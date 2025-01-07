

string input = Console.ReadLine();  

Stack<int> openBrackets = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        openBrackets.Push(i);   
    }
    if (input[i] == ')')
    {
        int openBracketIndex = openBrackets.Pop();

        Console.WriteLine(input.Substring(openBracketIndex, i - openBracketIndex + 1));
    }
}