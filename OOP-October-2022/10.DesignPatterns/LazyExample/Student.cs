namespace LazyExample
{
    internal class Student
    {
        public Student(string name)
        {
            System.Console.WriteLine("Constructor");
            Name = name;
        }

        public string Name { get; internal set; }
    }
}