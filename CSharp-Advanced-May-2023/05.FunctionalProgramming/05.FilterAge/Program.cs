List<Person> people = new List<Person>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ");
    people.Add(new Person() { Name = input[0], Age = int.Parse(input[1]) });
}

string filterType = Console.ReadLine();
int ageFilter = int.Parse(Console.ReadLine());
string formatType = Console.ReadLine();

Func<Person, bool> filter = GetFilter(filterType, ageFilter);

people = people.Where(filter).ToList();

Action<Person> printer = GetPrinter(formatType);

foreach (var person in people)
{
    printer(person);
}

Func<Person, bool> GetFilter(string filterType, int age)
{
    switch (filterType)
    {
        case "older": return person => 
        person.Age >= age;
        case "younger": return person => person.Age < age;
        default:
            return null;
    }
}

Action<Person> GetPrinter(string formatType)
{
    switch (formatType)
    {
        case "name age":
            return p => Console.WriteLine($"{p.Name} - {p.Age}");
        case "age":
            return p => Console.WriteLine($"{p.Age}");
        case "name":
            return p => Console.WriteLine($"{p.Name}");
        default:
            return null;
    }
}

class Person
{
    public string Name;
    public int Age;
}

