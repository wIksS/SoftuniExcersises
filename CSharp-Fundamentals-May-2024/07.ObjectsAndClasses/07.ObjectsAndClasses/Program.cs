

// students

// student -> pesho

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
int averageScore = int.Parse(Console.ReadLine());
List<int> scores = new List<int>();
List<string> courses = new List<string>();


string name2 = Console.ReadLine();
int age2 = int.Parse(Console.ReadLine());
int averageScore2 = int.Parse(Console.ReadLine());
List<int> scores2 = new List<int>();
List<string> courses2 = new List<string>();

string name3 = Console.ReadLine();
int age3 = int.Parse(Console.ReadLine());
int averageScore3 = int.Parse(Console.ReadLine());
List<int> scores3 = new List<int>();
List<string> courses3 = new List<string>();


void PrintStudent(string name, int age, List<int> scores, List<string> courses)
{
    Console.WriteLine(name);
    Console.WriteLine(age);
}
