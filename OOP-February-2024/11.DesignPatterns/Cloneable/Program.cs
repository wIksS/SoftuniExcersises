
using Newtonsoft.Json;

Course csharpOOP = new Course() { Name = "C# OOP" };

User user = new User() { Username="pesho", Course = csharpOOP};

User gosho = user.Clone() as User;

gosho.Username = "gosho";

gosho.Course.Name = "Javascript OOP";

Console.WriteLine(user.Course.Name);
Console.WriteLine(gosho.Course.Name);

class User : ICloneable
{
    public string Username { get; set; }

    public Course Course { get; set; }

    public object Clone()
    {
        // shallow copy
        //return this.MemberwiseClone(); 

        //return copy
        return JsonConvert.DeserializeObject<User>((JsonConvert.SerializeObject(this)));
    }
}

class Course
{
    public string Name { get; set; }
}