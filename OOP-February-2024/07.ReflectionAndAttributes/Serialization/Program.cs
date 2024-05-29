

//

Student gosho = new Student() { Id = 5, Name = "Gosho", Score = 3 };

// Deep copy - 
//JSONSerializer.ToJSON(gosho) -> "{ Id:5,Name:"Gosho", "Score":"3"}"
// JSONSerializer.FromJSON<Student>("{ Id:5,Name:"Gosho", "Score":"3"}") -> Student gosho

class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Score { get; set; }
}