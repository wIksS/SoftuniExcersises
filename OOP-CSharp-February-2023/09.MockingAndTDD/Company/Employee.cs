namespace Companies
{
    public class Employee
    {
        public Employee(string name, Score score, decimal salary)
        {
            Name = name;
            Score = score;
            Salary = salary;
        }

        public string Name { get; }
        public Score Score { get; }
        public decimal Salary { get; set; }
    }
}