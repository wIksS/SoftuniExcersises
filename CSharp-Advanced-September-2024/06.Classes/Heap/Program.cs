
Animal tiger = new Animal();
tiger.name = "Tigeryt";

PrintAnimal(tiger);

Console.WriteLine(tiger.name);

void PrintAnimal(Animal animal)
{
    Console.WriteLine(animal.name);
    animal.name = "Printed!";
}


class Animal
{
    public string name;
}