using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Employee"
            };

            employee.SayName();

            IQuittable quittable = employee;

            quittable.Quit();

            Console.ReadLine();
        }
    }
}
