

using PeopleComparable;

Person pesho = new Person("Pesho", 22, "Plovdiv", 1);
Person pesho2 = new Person("Pesho", 22, "Sofia", 2);
Person niki = new Person("Niki", 22, "Sofia", 3);

//Console.WriteLine($"GetHashCode: Pesho {pesho.GetHashCode()}");
//Console.WriteLine($"GetHashCode: Pesho2 {pesho2.GetHashCode()}");
//Console.WriteLine($"GetHashCode: Niki {niki.GetHashCode()}");

HashSet<Person> people = new HashSet<Person>();
SortedSet<Person> sortedPeople = new SortedSet<Person>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    var person = new Person(input[0], int.Parse(input[1]), "", -1);
    people.Add(person);
    sortedPeople.Add(person);
}

Console.WriteLine(people.Count);
Console.WriteLine(sortedPeople.Count);
//people.Add(pesho);
//people.Add(pesho2);

//people.Add(new Person("Test", 55, "", 55));

//foreach (var person in people)
//{
//    Console.WriteLine(person);
//}