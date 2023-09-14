using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    public class MathOperations
    {
        public void PerformMathOperation(int number1, int number2)
        {
            int result = number1 * 2;
            Console.WriteLine($"Result of the math operation: {result}");
            Console.WriteLine($"Second integer: {number2}");
        }
    }
}
