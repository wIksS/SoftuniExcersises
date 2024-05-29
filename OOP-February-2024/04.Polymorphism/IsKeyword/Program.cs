int i = 0;
const int min = 0, max = 10;

while (true)
{
    Console.WriteLine($"i is {i}");
    i++;
    if (i is max or min) break;
}

