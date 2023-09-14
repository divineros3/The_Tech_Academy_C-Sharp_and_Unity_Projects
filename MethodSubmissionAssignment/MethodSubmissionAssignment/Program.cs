using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main()
        {
            MathOperations mathOperations = new MathOperations();

            Console.Write("Enter the first number: ");
            if (int.TryParse(Console.ReadLine(), out int number1))
            {
                Console.Write("Enter the second number (optional, press Enter to skip): ");
                string input = Console.ReadLine();
                int number2 = 0;
                
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (int.TryParse(input, out int parsedNumber))
                    {
                        number2 = parsedNumber;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for the second number. Using 0 as the default.");
                    }
                }

                int result = mathOperations.Calculate(number1, number2);
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input for the first number.");
            }

            Console.ReadLine();
        }
    }
}
