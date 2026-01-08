

char[] expression = Console.ReadLine().ToCharArray();

char[] openBracketsSymbols = ['(', '{', '['];
Dictionary<char, char> paranthesisPair = new Dictionary<char, char>()
{
    { ')','('},
    { ']','['},
    { '}','{'}
};
Stack<char> openBrackets = new Stack<char>();
bool isBalanced = false;
//{[()]}
for (int i = 0; i < expression.Length; i++)
{
    if (openBracketsSymbols.Contains(expression[i]))
    {
        openBrackets.Push(expression[i]);
    }
    else
    {
        isBalanced = true;
        if (openBrackets.Count == 0)
        {
            isBalanced = false;
            break;
        }

        char openBracket = openBrackets.Pop();
        char closingBracket = expression[i];
        char corresondingBracket = paranthesisPair[closingBracket];
        if (corresondingBracket != openBracket)
        {
            isBalanced = false;
            break;
        }
    }
}

if (isBalanced)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}