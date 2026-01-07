// 

Stack<int> numbers = new Stack<int>();

numbers.Push(0);  
numbers.Push(1);
numbers.Push(2);
numbers.Push(3);
numbers.Push(4);

int[] array = numbers.ToArray();

while (numbers.Count > 0)
{
    int number = numbers.Pop();
    Console.WriteLine(number);
}