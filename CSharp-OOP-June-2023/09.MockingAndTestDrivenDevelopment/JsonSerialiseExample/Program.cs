
using Newtonsoft.Json;
List<Student> students = new List<Student>();
students.Add(new Student() { Age = 43, Name = "dimitrichko" });
students.Add(new Student() { Age = 42, Name = "goshko" });

string studentAsAString = JsonConvert.SerializeObject(students);
Console.WriteLine(studentAsAString);

using (StreamWriter writer = new StreamWriter("../../../db.txt"))
{
    writer.WriteLine(studentAsAString);
}

string db = "[{\"Name\":\"dimitrichko\",\"Age\":43},{\"Name\":\"goshko\",\"Age\":42}]";

List<Student> dbList = JsonConvert.DeserializeObject<List<Student>>(db);

Console.WriteLine(dbList.Count);
class Student
{
    public string Name { get; set; }

    public int Age{ get; set; }
}