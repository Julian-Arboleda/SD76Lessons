using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance.People
{
    public class Employee : User
    {
        // Constructor                     // Base (User) Constructor
        public Employee(string email) : base(email, "Employee") { }

        // Properties ( in additioin to the User properties)
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int YearsWithCompany
        {
            get
            {                       // Timespan
                double totalTime = (DateTime.Now - HireDate).TotalDays / 365.24;
                return Convert.ToInt32(Math.Floor(totalTime));
                // Math.Ceiling (24.3) => 25
                // Math.Floor (3.8) => 3
            }
        }

    }

    public class HourlyEmployee : Employee
    {
        public HourlyEmployee(string email) : base(email) { }
        public decimal HourlyWage { get; set; }
        public double HoursWorked { get; set; }
    }

    public class SalaryEmployee : Employee
    {
        public SalaryEmployee(string email) : base(email) { } // Take email from string and connects it to base
        public decimal Salary { get; set; }
    }
}
