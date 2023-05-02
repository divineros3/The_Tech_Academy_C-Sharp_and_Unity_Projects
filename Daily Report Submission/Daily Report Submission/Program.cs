using System;


namespace Daily_Report_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");

            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You are on the " + courseName);
            Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("You are on page number " + pageNum);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string needHelp = Console.ReadLine();
            bool needHlp = Convert.ToBoolean(needHelp);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("How many Hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int studyHours = Convert.ToInt32(hoursStudied);
            Console.WriteLine("You have studied " + studyHours + " hours today!");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
