int age = 0;
while (age == 0)
{
    try
    {
        Console.WriteLine("Enter your age: [1, 120]");
        int input = int.Parse(Console.ReadLine());

        if (input < 1 || input > 120)
        {
            throw new ArgumentException("Age must be between 1 and 120");
        }

        age = input;
        
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}