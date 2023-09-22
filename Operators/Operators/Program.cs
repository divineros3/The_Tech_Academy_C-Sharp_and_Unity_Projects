using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };
            Employee employee3 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

            bool areEqual1 = employee1 == employee2;
            bool areEqual2 = employee1 == employee3;

            Console.WriteLine("Are employee1 and employee2 equal? " + areEqual1);
            Console.WriteLine("Are employee1 and employee3 equal? " + areEqual2);

            Console.ReadLine();
        }
    }
}
