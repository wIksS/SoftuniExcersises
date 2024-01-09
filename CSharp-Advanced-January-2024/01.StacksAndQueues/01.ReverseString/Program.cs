char[] chars = Console.ReadLine().ToCharArray();
Stack<char> text = new Stack<char>(chars);
//foreach (var item in input)
//{
//    text.Push(item);
//}


while (text.Count != 0)
{
    Console.Write(text.Pop());
}
