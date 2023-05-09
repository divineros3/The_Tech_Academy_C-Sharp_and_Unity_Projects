using System;

namespace Math_and_Comparison_Operators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            int hours1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            int hours2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1:");
            int salary1 = rate1 * hours1 * 52;
            Console.WriteLine(salary1);

            Console.WriteLine("Annual Salary of Person 2:");
            int salary2 = rate2 * hours2 * 52;
            Console.WriteLine(salary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(salary1 > salary2);
            Console.ReadLine();
        }
    }
}
