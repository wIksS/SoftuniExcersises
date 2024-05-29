

int[] numbers = new int[7];

numbers[0] = 55;
numbers[6] = 47;
numbers[2] = 10;

Console.WriteLine("Which element would you like to read?");

int index = int.Parse(Console.ReadLine());

if (index >= 0 && index < numbers.Length)
{
    Console.WriteLine(numbers[index]);
}
else
{
    Console.WriteLine("Kakyv e tozi index???");
}

//Console.WriteLine(numbers[0]);
//Console.WriteLine(numbers[6]);
//Console.WriteLine(numbers[3]);

