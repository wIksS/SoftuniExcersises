

Action<string> print = Console.WriteLine;
Action lambdaPrint = () =>
{
    Console.WriteLine("empty method");
};

lambdaPrint();

print("hello");

print("wow");

//int Add(int a, int b)
//{
//    return a + b;
//}