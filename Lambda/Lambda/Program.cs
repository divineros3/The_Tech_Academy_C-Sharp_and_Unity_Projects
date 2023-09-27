using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Doe" },
            new Employee { Id = 2, FirstName = "Alice", LastName = "Smith" },
            new Employee { Id = 3, FirstName = "Bob", LastName = "Johnson" },
            new Employee { Id = 4, FirstName = "Joe", LastName = "Brown" },
            new Employee { Id = 5, FirstName = "Mary", LastName = "Davis" },
            new Employee { Id = 6, FirstName = "Sarah", LastName = "Wilson" },
            new Employee { Id = 7, FirstName = "Joe", LastName = "Clark" },
            new Employee { Id = 8, FirstName = "David", LastName = "Lee" },
            new Employee { Id = 9, FirstName = "Linda", LastName = "White" },
            new Employee { Id = 10, FirstName = "Tom", LastName = "Miller" }
        };

        List<Employee> joes = new List<Employee>();
        foreach (var employee in employees)
        {
            if (employee.FirstName == "Joe")
            {
                joes.Add(employee);
            }
        }

        List<Employee> joesLambda = employees.Where(employee => employee.FirstName == "Joe").ToList();

        List<Employee> idsGreaterThan5 = employees.Where(employee => employee.Id > 5).ToList();

        Console.WriteLine("Employees with the first name 'Joe' (foreach loop):");
        foreach (var joe in joes)
        {
            Console.WriteLine($"{joe.FirstName} {joe.LastName}");
        }

        Console.WriteLine("\nEmployees with the first name 'Joe' (lambda expression):");
        foreach (var joe in joesLambda)
        {
            Console.WriteLine($"{joe.FirstName} {joe.LastName}");
        }

        Console.WriteLine("\nEmployees with an Id greater than 5 (lambda expression):");
        foreach (var employee in idsGreaterThan5)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}, Id: {employee.Id}");
        }

        Console.ReadLine();
    }
}
