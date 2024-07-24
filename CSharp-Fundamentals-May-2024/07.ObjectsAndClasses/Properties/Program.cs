Console.WriteLine();
Dog emptyDog = new Dog();

Dog dog = new Dog()
{ Age = 16, Name = "Sharo", LastDoctorVisit = DateTime.Now };
dog.WalkTime = 5;


class Dog
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int WalkTime { get; set; }

    public DateTime LastDoctorVisit { get; set; }

}