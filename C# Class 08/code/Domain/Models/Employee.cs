using Domain.Enums;

namespace Domain.Models
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public RoleEnum Role { get; set; }

        protected double Salary { get; set; }

        protected Employee()
        {
            //default constructor 
        }
        public Employee(string firstName, string lastName, RoleEnum role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} gets salary: {Salary} ");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
