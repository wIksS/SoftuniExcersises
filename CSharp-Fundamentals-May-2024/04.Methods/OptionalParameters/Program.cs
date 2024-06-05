
Greet(3.3);
Greet(2.0, "Pesho",55);


void Greet(double grade, string name = "Unknown", int age = 55)
{
    Console.WriteLine(name + " " + age);
}