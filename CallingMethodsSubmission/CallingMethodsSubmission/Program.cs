using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    class Program
    {
        static void Main()
        {
            MathOperations mathOperations = new MathOperations();

            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                int result1 = mathOperations.AddFive(userInput);
                int result2 = mathOperations.Square(userInput);
                int result3 = mathOperations.Double(userInput);

                Console.WriteLine($"Result of adding 5: {result1}");
                Console.WriteLine($"Result of squaring: {result2}");
                Console.WriteLine($"Result of doubling: {result3}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.ReadLine();
        }
    }
}
