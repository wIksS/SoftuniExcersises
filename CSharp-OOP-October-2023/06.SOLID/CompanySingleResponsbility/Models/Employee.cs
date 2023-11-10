namespace CompanySingleResponsbility
{
    public class Employee
    {
        public string Name { get; internal set; }
        public decimal Salary { get; internal set; }
        public int YearsInCompany { get; set; }
    }
}