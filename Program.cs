using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employee> employeeList = new List<Employee>();

        // Create a method that allows external code to add an employee
        public void addEmployee(Employee employee){
            employeeList.Add(employee);
        }

        // Create a method that allows external code to remove an employee
        public void removeEmployee(Employee employee){
            employeeList.Remove(employee);
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime createdOn) {
            Name = name;
            CreatedOn = createdOn;
        }

        // Method to write out list of employees
        public void ListEmployees() {
            foreach (Employee person in employeeList) {
                Console.WriteLine($"{person.Name}, {person.Title}, {person.CreatedOn}");
            }
        }
    }

    public class Employee
    {
        public string Name {get; set;}
        public string Title {get; set;}
        public DateTime CreatedOn {get;}

        public Employee (string name, string title, DateTime started)
        {
            Name = name;
            Title = title;
            CreatedOn = started;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company CozyBoyz = new Company("CozyBoyz", DateTime.Now);
            Employee asshole = new Employee("Frank", "Bastard", DateTime.Now);
            Employee second = new Employee("Mary", "Cyclist", DateTime.Now);
            Employee third = new Employee("Zac", "Meme maker", DateTime.Now);

            CozyBoyz.addEmployee(asshole);
            CozyBoyz.addEmployee(second);
            CozyBoyz.addEmployee(third);

            CozyBoyz.ListEmployees();
            
        }
    }
}
