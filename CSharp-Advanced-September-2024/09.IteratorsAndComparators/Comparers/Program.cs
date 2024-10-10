

using Comparers;

Student dimitrichko = new Student("Dimi", 6, "Softuni");
Student goshko = new Student("Goshko", 2,"Softuni");
Student pepi = new Student("Pepi", 4, "Kids Softuni");
Student gogi = new Student("Gogi", 3, "Kids Softuni");


IComparer<Student> comparer = new NameComparer();

//Console.WriteLine(comparer.Compare(dimitrichko, goshko));
//Console.WriteLine(comparer.Compare(pepi, gogi));
//Console.WriteLine(comparer.Compare(dimitrichko,pepi));

List<Student> students = new List<Student>();

students.Add(dimitrichko);
students.Add(goshko);
students.Add(pepi);
students.Add(gogi);

SortedSet<Student> nameSortedStudents = new SortedSet<Student>(students, new NameComparer());
SortedSet<Student> scoreSortedStudents = new SortedSet<Student>(students, new ScoreComparer());
List<Student> universitySortedStudents = new List<Student>(students);

foreach (var student in nameSortedStudents)
{
    Console.WriteLine($"{student.Name} : {student.Score}, {student.University}");
}
Console.WriteLine();
foreach (var student in scoreSortedStudents)
{
    Console.WriteLine($"{student.Name} : {student.Score}, {student.University}");
}
Console.WriteLine();
universitySortedStudents.Sort(new UniversityComparer());
foreach (var student in universitySortedStudents)
{
    Console.WriteLine($"{student.Name} : {student.Score}, {student.University}");
}