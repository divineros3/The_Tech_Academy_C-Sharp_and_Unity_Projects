using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 0 and 50.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 3;

            do
            {
                while (!isGuessed)
                {
                    switch (number)
                    {
                        case 46:
                            Console.WriteLine("You guessed 46. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 21:
                            Console.WriteLine("You guessed 21. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 10:
                            Console.WriteLine("You guessed 10. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("You guessed 3. That is correct!");
                            isGuessed = true;
                            break;
                        default:
                            Console.WriteLine("That is incorrect.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
            }
            while (isGuessed);

            Console.ReadLine();
        }
    }
}
