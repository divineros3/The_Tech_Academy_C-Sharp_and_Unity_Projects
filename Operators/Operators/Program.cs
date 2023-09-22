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
            Employee<string> stringEmployee = new Employee<string>
            {
                Things = new List<string> { "Apple", "Banana", "Cherry" }
            };

            Employee<int> intEmployee = new Employee<int>
            {
                Things = new List<int> { 1, 2, 3, 4, 5 }
            };

            Console.WriteLine("Things for stringEmployee:");
            foreach (var item in stringEmployee.Things)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nThings for intEmployee:");
            foreach (var item in intEmployee.Things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
