

int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

//int[] evenNumbers = array.Where(number =>
//{
//    Console.WriteLine($"{number} % 2 = {number % 2}");

//    return number % 2 == 0;
//}).ToArray();

int[] evenNumbers = array.Where((int number, int index) =>
{
    Console.WriteLine($"Index:{index}.{number} % 2 = {number % 2}");

    return number % 2 == 0;
}).ToArray();




//int[] evenNumbers = array.Where(IsEven).ToArray();

Console.WriteLine(String.Join(",", evenNumbers));

bool IsEven(int number)
{
    Console.WriteLine($"{number} % 2 = {number % 2}");
    return number % 2 == 0;
}