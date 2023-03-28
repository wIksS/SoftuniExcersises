namespace Companies
{
    public class Company
    {

        private List<Employee> employees;

        public Company()
        {
            employees = new List<Employee>();
            UnderAchievers = new List<Employee>();
        }

        public List<Employee> UnderAchievers { get; set; }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            if (employee.Score == Score.UnderAchiever)
            {
                UnderAchievers.Add(employee);
            }
        }

        public void IncreaseSalary()
        {
            foreach (var employee in employees)
            {
                if (employee.Score == Score.OverAchiever)
                {
                    employee.Salary += employee.Salary * 2;
                }
            }
        }
    }
}