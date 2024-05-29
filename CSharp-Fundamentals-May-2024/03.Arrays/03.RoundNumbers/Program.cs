//string[] input = Console.ReadLine()
//    .Split(" ");
//double[] doubleNumbers = new double[input.Length];
//for (int i = 0; i < input.Length; i++)
//{
//    doubleNumbers[i] = double.Parse(input[i]);
//}

double[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(double.Parse)
    .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    double roundedNumber =(int) Math.Round(numbers[i], MidpointRounding.AwayFromZero);

    Console.WriteLine($"{numbers[i]} => {roundedNumber}");
}


