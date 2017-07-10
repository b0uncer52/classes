using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime later = now.AddDays(1);
            Company loogle = new Company("loogle", now);

            Employee jason = new Employee(){
                title = "master",
                name = "jason",
                start = now
            };
            Employee andy = new Employee() {
                title = "peon",
                name = "andy",
                start = later
            };
            Employee ryan = new Employee() {
                title = "funny guy",
                name = "ryan",
                start = later
            };
            loogle.AddEmployee(ryan);
            loogle.AddEmployee(jason);
            loogle.AddEmployee(andy);
            loogle.RemoveEmployee(andy);
            List<Employee> employees = loogle.ListEmployees();

            foreach(Employee e in employees) {
                Console.WriteLine($"{e.name} started as a {e.title} on {e.start}");
            }

        }
    }
}
public class Company
{
    /*
        Some readonly properties
    */
    public string name;
    public DateTime createdOn;
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a property for holding a list of current employees
    List<Employee> employees = new List<Employee>();

    // Create a method that allows external code to add an employee
    public void AddEmployee(Employee e) {
        employees.Add(e);
    }
    // Create a method that allows external code to remove an employee
    public void RemoveEmployee(Employee e) {
        employees.Remove(e);      
    }

    public List<Employee> ListEmployees(){
        return employees;
    }
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public Company(string n, DateTime d) {
        this.name = n;
        this.createdOn = d;
    }
}
public class Employee 
{
    public string name;
    public string title;
    public DateTime start;

    public string Name{get; set;}

    public DateTime Start{get; set;}

    public string Title{get; set;}
}