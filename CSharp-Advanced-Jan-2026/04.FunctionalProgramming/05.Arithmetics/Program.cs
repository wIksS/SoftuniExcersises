
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();//[1, 2, 3, 4, 5, 6, 7];

string command = Console.ReadLine();

while (command != "end")
{
    Func<int, int> manipulator = null;

    switch (command)
    {
        case "add":
            manipulator = x => x + 1;
            break;
        case "multiply":
            manipulator = x => x * 2;
            break;
        case "subtract":
            manipulator = x => x - 1;
            break;
        case "print":
            Console.WriteLine(String.Join(" ", array));
            //manipulator = x =>
            //{
            //    Console.Write($"{x} ");
            //    return x;
            //};
            break;
        default:
            break;
    }

    if (manipulator != null)
    {
        ManipulateArray(array, manipulator);
    }

    command = Console.ReadLine();
}

void ManipulateArray(int[] array, Func<int, int> manipulator)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = manipulator(array[i]);
    }
}

int Divide(int x)
{
    return x / 2;
}