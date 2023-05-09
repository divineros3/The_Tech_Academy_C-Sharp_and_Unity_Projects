using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package is too big to be shipped vis Package Express.");
                }
                else
                {
                    int result = (packageWidth * packageHeight * packageLength * packageWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + result + "\nThank you!");
                }
            }
            Console.ReadLine();
        }
    }
}
