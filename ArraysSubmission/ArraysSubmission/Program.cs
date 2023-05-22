using System;
using System.Collections.Generic;


namespace ArraysSubmission
{
    class Program
    {
        static void Main()
        {
            List<string> inList = new List<string>();
            inList.Add("Hello");
            inList.Add("My name is Divine");
            inList.Add("My favorite color is pink");

            Console.WriteLine("Please select an index number.");
            int ListIndex = Convert.ToInt32(Console.ReadLine());
            if (ListIndex < 0 || ListIndex > inList.Count - 1)
            {
                Console.WriteLine("Index does not exist.");
            }
            else
            {
                Console.WriteLine(inList[ListIndex]);
            }
            Console.ReadLine();

            int[] numArray = new int[] { 1, 3, 5, 7, 9, 0, 2, 4, 6, 8 };

            Console.WriteLine("Please select an index number.");
            int numIndex = Convert.ToInt32(Console.ReadLine());
            if(numIndex < 0 || numIndex > numArray.Length - 1)
            {
                Console.WriteLine("Index does not exist.");
            }
            else
            {
                Console.WriteLine(numArray[numIndex]);
            }
            Console.ReadLine();
        }
    }
}
