﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class MathOperations
    {
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine($"Result of division by 2: {result}");
        }

        public void DivideByTwo(int number, out int result)
        {
            result = number / 2;
        }
    }
}
