using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main()
        {
            MathOperations mathOperations = new MathOperations();

            Console.Write("Enter the first number: ");
            if (int.TryParse(Console.ReadLine(), out int number1))
            {
                Console.Write("Enter the second number: ");
                if (int.TryParse(Console.ReadLine(), out int number2))
                {
                    mathOperations.PerformMathOperation(number1, number2);
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number.");
            }

            Console.WriteLine("Enter the first number again: ");
            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.Write("Enter the second number again: ");
                if (int.TryParse(Console.ReadLine(), out int num2))
                {
                    mathOperations.PerformMathOperation(number1: num1, number2: num2);
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number.");
            }

            Console.ReadLine();
        }
    }
}
