
int number = Print(5);

Print<int>(5);
Print(5);

Console.WriteLine(number);

PrintVoid<int>();

T Print<T>(T element)
{
    T variable = default(T);
    Console.WriteLine(element);

    return element;
}

void PrintVoid<T>()
{
    T x;
}