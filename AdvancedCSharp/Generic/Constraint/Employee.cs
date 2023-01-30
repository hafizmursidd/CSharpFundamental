using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generic.Constraint
{

    internal interface IEmployee { 
    
    }
    internal class Employee : IEmployee
    {
        public Employee(string? nama, double? salary)
        {
            Nama = nama;
            Salary = salary;
        }

        public override string? ToString()
        {
            return $"Nama: {Nama}, Salary: {Salary}";
        }

        public string? Nama { get; set; }
        public double? Salary { get; set; }
    }

    internal class Person : IEmployee { 
        
    }

    internal class EmployeeRepository<T> where T : IEmployee
    {
        readonly List<Employee> listOfEmployee = new();

        public void AddEmployee(Employee employee) 
        {            
            listOfEmployee.Add(employee);
        }

        public void DisplayEmployee() {

            Console.WriteLine("Display Employee: ");

            foreach (var emp in listOfEmployee)
            {
                Console.WriteLine(emp.ToString());
            }
        
        }
    }
}
