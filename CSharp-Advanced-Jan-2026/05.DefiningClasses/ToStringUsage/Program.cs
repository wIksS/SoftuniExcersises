namespace ToStringUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Niki",
                Age = 20
            };

            //Console.WriteLine($"{student.Name} - {student.Age}");
            //Console.WriteLine(student.ToString());
            Console.WriteLine(student);
        }
    }

    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }
}
