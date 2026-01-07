
string input = Console.ReadLine();

Stack<char> stack = new Stack<char>(input.ToCharArray());

//for (int i = 0; i < input.Length; i++)
//{
//    stack.Push(input[i]);
//}

foreach (char symbol in stack)
{
    Console.Write(symbol);
}