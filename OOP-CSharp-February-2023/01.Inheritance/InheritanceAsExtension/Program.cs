

class Person
{
    public string Name { get; set; }
}

class Student : Person
{
    private Person person = new Person();
}