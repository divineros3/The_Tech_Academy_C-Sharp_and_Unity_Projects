using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    public class MathOperations
    {
        public int Calculate(int number)
        {
            return number + 10;
        }

        public int Calculate(decimal number)
        {
            return (int)(number * 2);
        }

        public int Calculate(string input)
        {
            if (int.TryParse(input, out int number))
            {
                return number - 5;
            }
            else
            {
                throw new ArgumentException("Input is not a valid integer.");
            }
        }
    }
}
