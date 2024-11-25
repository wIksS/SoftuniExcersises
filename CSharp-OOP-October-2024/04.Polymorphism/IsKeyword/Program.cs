
const int min = 10;
const int max = 100;

int n = int.Parse(Console.ReadLine());

if (n is min or max)
{
    Console.WriteLine("10 or 100");
}