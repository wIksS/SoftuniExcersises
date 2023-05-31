
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

string sign = Console.ReadLine();

Func<int, int, string> operation = null;

if (sign == "+")
{
    operation = Sum;
}
if (sign == "-")
{
    operation = Minus;
}

Console.WriteLine(operation(a,b));


string Sum(int a , int b)
{
    return $"{a} + {b} = {a + b}";
}

string Minus(int a, int b)
{
    return $"{a} - {b} = {a - b}";
}