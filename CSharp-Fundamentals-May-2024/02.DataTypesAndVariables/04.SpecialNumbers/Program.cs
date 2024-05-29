int n = int.Parse(Console.ReadLine());

//5, 7 or 11

for (int i = 1; i <= n; i++)
{
    int currentNumber = i;
    int digitSum = 0;
    while (currentNumber > 0)
    {
        digitSum += currentNumber % 10;
        currentNumber /= 10;
    }

    bool isSpecial = false;
    if (digitSum == 5 || digitSum == 7 || digitSum == 11)
    {
        isSpecial = true;
    }

    Console.WriteLine($"{i} -> {isSpecial}");
}