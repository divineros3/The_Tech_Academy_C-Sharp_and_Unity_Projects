using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inList = new string[] { "Hello ", "My name is Divine ", "My favorite color is pink " };
            Console.WriteLine("Please input some text.");
            string inputText = Console.ReadLine();
            for (int i = 0; i < inList.Length; i++)
            {
                inList[i] += inputText;
            }

            foreach (string str in inList)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();

            ////Inifnite loop
            //for (int a = 0; a < 50; a--)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();

            //Infinite loop fixed
            for (int a = 0; a < 50; a++)
            {
                Console.WriteLine("value : {0}", a);
            }
            Console.ReadLine();

            for (int b = 0; b < 30; b++)
            {
                Console.WriteLine("value : {0}", b);
            }
            Console.ReadLine();

            for (int b = 0; b <= 30; b++)
            {
                Console.WriteLine("value : {0}", b);
            }
            Console.ReadLine();

            List<string> inList2 = new List<string> { "Homie", "Pulane", "Starbucks" };
            Console.WriteLine("Please input some text.");
            string inputText2 = Console.ReadLine();
            for (int i = 0; i < inList2.Count; i++)
            {
                if (inList2[i] == inputText2)
                {
                    Console.WriteLine("Your item was found at index " + i);
                }
                else if (!inList2.Contains(inputText2))
                {
                    Console.WriteLine("Item not found.");
                    break;
                }
            }
            Console.ReadLine();

            List<string> inList3 = new List<string> { "Big", "Blue", "Wrong", "Wrong" };
            Console.WriteLine("Please input some text.");
            string inputText3 = Console.ReadLine();
            for (int i = 0; i < inList3.Count; i++)
            {
                if (inList3[i] == inputText3)
                {
                    Console.WriteLine("Your item was found at index " + i);
                }
                else if (!inList3.Contains(inputText3))
                {
                    Console.WriteLine("Item was not found.");
                }
            }
            Console.ReadLine();

            List<string> inList4 = new List<string> { "Home", "Germany", "Far", "Far" };
            List<string> inList5 = new List<string> { };
            foreach (string i in inList4)
            {
                if (inList5.Contains(i))
                {
                    Console.WriteLine(i + " has been seen before.");
                }
                else
                {
                    Console.WriteLine(i + " has not been seen before.");
                    inList5.Add(i);
                }
            }
            Console.ReadLine();
        }
    }
}
