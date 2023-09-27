using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuessday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the current day of the week: ");
                string userInput = Console.ReadLine();

                if (Enum.TryParse(userInput, true, out DaysOfWeek day))
                {
                    Console.WriteLine($"You entered: {day}");
                }
                else
                {
                    Console.WriteLine($"Please enter a day of the week.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
