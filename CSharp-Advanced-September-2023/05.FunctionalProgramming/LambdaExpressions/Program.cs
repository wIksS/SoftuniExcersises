

List<int> numbers = new List<int>() { 1, 2, 3, 4 };

//numbers = numbers.Where(x => x % 2 == 0).ToList();
numbers = numbers.Where(IsEven).ToList();
numbers.ForEach(x => Console.WriteLine(x));
//numbers.ForEach(Print);

bool IsEven(int x)
{
    return true;
}


void Print(int x)
{
    Console.WriteLine(x);
}