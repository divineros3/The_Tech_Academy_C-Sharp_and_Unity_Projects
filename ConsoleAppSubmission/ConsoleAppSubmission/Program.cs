﻿using System;

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
            while (!isGuessed);

            Console.ReadLine();


            Console.WriteLine("Guess a number between 0 and 50.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            bool isGuessed1 = number1 == 7;

            while (!isGuessed1)
            {
                switch (number1)
                {
                    case 46:
                        Console.WriteLine("You guessed 46. Try again.");
                        Console.WriteLine("Guess a number?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 21:
                        Console.WriteLine("You guessed 21. Try again.");
                        Console.WriteLine("Guess a number?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You guessed 10. Try again.");
                        Console.WriteLine("Guess a number?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 7. That is correct!");
                        isGuessed1 = true;
                        break;
                    default:
                        Console.WriteLine("That is incorrect.");
                        Console.WriteLine("Guess a number?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }


            Console.ReadLine();
        }
    }
}
