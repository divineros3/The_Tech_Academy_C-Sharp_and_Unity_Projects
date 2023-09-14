using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main()
        {
            MathOperations mathOperations = new MathOperations();

            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                mathOperations.DivideByTwo(userInput);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            int sum = StaticMathOperations.Add(5, 3);
            Console.WriteLine($"Sum: {sum}");

            Console.ReadLine();
        }
    }
}
