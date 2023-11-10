using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySingleResponsbility
{
    public class Company
    {
        private List<Employee> employees;
        private EmployeeDataService employeeDataService;
        private EmployeeReportService employeeReportService;
        private SalaryService salaryService;

        public Company()
        {
            employees = new List<Employee>();
            employeeDataService = new EmployeeDataService();
            employeeReportService = new EmployeeReportService();
            salaryService = new SalaryService();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void NewYearUpdate()
        {
            employeeDataService.AddTenure(employees);
            salaryService.PayBonus(employees, 300);
            employeeReportService.PrintReport(employees);
        }

        public void Report()
        {
            employeeReportService.PrintReport(employees);
        }
    }
}
