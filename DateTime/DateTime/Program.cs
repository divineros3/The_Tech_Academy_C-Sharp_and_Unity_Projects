using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main()
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + currentDateTime);

            Console.Write("Enter a number of hours: ");
            if (int.TryParse(Console.ReadLine(), out int hours))
            {
                DateTime futureTime = currentDateTime.AddHours(hours);
                Console.WriteLine($"Exact time in {hours} hours: {futureTime}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of hours.");
            }
            Console.ReadLine();
        }
    }
}
