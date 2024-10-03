
int n = int.Parse(Console.ReadLine());
List<Person> people = new List<Person>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ");
    string name = input[0];
    int age = int.Parse(input[1]);

    people.Add(new Person() { Name = name, Age = age });
}

string filterInput = Console.ReadLine();
int ageFilter = int.Parse(Console.ReadLine());
string format = Console.ReadLine();


Func<Person, bool> filterFunc = CreateFilter(filterInput, ageFilter);

people = FilterPeople(people, filterFunc);

List<Person> FilterPeople(List<Person> people, Func<Person, bool> filter)
{
    List<Person> list = new List<Person>();
    foreach (var person in people)
    {
        if (filter(person))
        {
            list.Add(person);
        }
    }
    return list;
}

Func<Person, string> formatterFunc = null;
switch (format)
{
    case "name":
        formatterFunc = person => person.Name;
        break;
    case "age":
        formatterFunc = person => person.Age.ToString();
        break;
    case "name age":
        formatterFunc = person => $"{person.Name} - {person.Age}";
        break;
    case "age name":
        formatterFunc = person => $"WOW custom formatter {person.Age} {person.Name}";
        break;
    default:
        break;
}

PrintStudents(people, formatterFunc);

void PrintStudents(List<Person> people, Func<Person, string> formatter)
{
    foreach (Person person in people)
    {
        Console.WriteLine(formatter(person));
    }
}

 Func<Person, bool> CreateFilter
 (string condition, int ageThreshold)
{
    switch (condition)
    {
        case "younger": return x => x.Age < ageThreshold;
        case "older": return x => x.Age >= ageThreshold;
        default: throw new ArgumentException(condition);
    }
}


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}