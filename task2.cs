using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2 задание
//Open-Closed Principle
namespace HomeWork4
{
    public class Employee
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public string EmployeeType { get; set; } // "Permanent", "Contract", "Intern"
    }
    public interface SalaryCalculator
    {
        public double CalculateSalary(Employee employee);
    }
    public class PermanentSalaryCalculator : SalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            return employee.BaseSalary * 1.2; // Permanent employee gets 20% bonus
        }
    }
    public class ContractSalaryCalculation : SalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            return employee.BaseSalary * 1.1; // Contract employee gets 10% bonus
        }
    }
    public class InternSalaryCalculation : SalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            return employee.BaseSalary * 0.8; // Intern gets 80% of the base salary        }
        }
    }
}
