﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 12345
            };

            employee.SayName();

            Console.ReadLine();
        }
    }
}
