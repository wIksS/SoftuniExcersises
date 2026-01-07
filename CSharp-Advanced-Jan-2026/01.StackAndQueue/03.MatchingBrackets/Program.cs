
// 1.Foreach every char in expression
// 2.if char is opening bracket ->add index to stack
// 2.if char is closing bracket -> 2.1pop last open bracket
// 2.2 and print expression

string expression = Console.ReadLine();

Stack<int> openBracketsIndex = new Stack<int>();
//1+((5+2)*(3+4)+3)+3

for (int i = 0; i < expression.Length; i++)
{
	if (expression[i] == '(')
	{
        openBracketsIndex.Push(i);
    }
    else if (expression[i] == ')')
    {
        // open - 2, i - 6
        int openIndex = openBracketsIndex.Pop();
        int end = i;
        string subExpr = expression.Substring(openIndex, end - openIndex + 1);
        Console.WriteLine(subExpr);
    }
}