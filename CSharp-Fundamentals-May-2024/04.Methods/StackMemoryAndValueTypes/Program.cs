
using System.Text;


int number = 5;

int number2 = number;

number2 = 155;

Console.WriteLine(number);

int[] array = { 1, 2, 3 };

Console.WriteLine(array);

int[] other = array;

Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);

other[0] = -50;
other[1] = -55;
other[2] = -56;

Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);