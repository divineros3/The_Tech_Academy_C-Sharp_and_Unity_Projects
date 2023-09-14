using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main()
        {
            MathOperations mathOperations = new MathOperations();

            int result1 = mathOperations.Calculate(20);
            Console.WriteLine($"Result for integer input: {result1}");

            decimal decimalInput = 7.5M;
            int result2 = mathOperations.Calculate(decimalInput);
            Console.WriteLine($"Result for decimal input {result2}");

            string stringInput = "15";
            int result3 = mathOperations.Calculate(stringInput);
            Console.WriteLine($"Result for string input: {result3}");

            Console.ReadLine();
        }
    }
}
