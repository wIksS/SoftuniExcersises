
string typeOfStudent = "Average";
TypeOfStudent type = TypeOfStudent.Average;


void PrintStudent(string name, TypeOfStudent studentType)
{
    if (studentType == TypeOfStudent.Great || studentType == TypeOfStudent.Average)
    {
        Console.WriteLine("Name");
    }
}

void PrintStudent(string name, string studentType)
{
    if (studentType == "Great" || studentType == "Average")
    {
        Console.WriteLine("Name");
    }
}
//Otlichnici
// Sredni
// Dvoikadjii

enum TypeOfStudent
{
    Great,
    Average,
    Bad
}