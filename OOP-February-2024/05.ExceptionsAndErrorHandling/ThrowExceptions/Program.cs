

Console.WriteLine("What is your age?");

int age = int.Parse(Console.ReadLine());

ArgumentException ageException = new ArgumentException("Your age cannot be less than zero :(");


if (age < 0)
{
    throw ageException;
}

Console.WriteLine($"In 10 years you will be: {age + 10}");