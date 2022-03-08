using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MadLibs
    {
        public static void ValentinesDay()
        {
            Console.WriteLine("Welcome to Madlibs!");
            Console.Write("Enter Noun > ");
            string PresentForme1 = Console.ReadLine();
            Console.Write("Enter Adjective> ");
            string DecriptionOfPresent = Console.ReadLine();
            Console.Write("Enter Noun > ");
            string PresentForme2 = Console.ReadLine();
            Console.Write("Enter Noun > ");
            string Present = Console.ReadLine();
            Console.Write("Enter Someones name other than yourself > ");
            string Name = Console.ReadLine();
            Console.Write("Enter number > ");
            int age = Convert.ToInt32(Console.ReadLine());
            string Answer = (age % 2 == 0) ? "good" : "bad";
            Console.Write("Enter Verb ending in ing > ");
            string Enjoy = Console.ReadLine();
            Console.WriteLine("\nFor Valentines day I want a {0} and {1} {2}.", PresentForme1, DecriptionOfPresent, PresentForme2);
            Console.WriteLine("I got my friends and family a {0} for Valentines day.", Present);
            Console.WriteLine("I hope {0} has a {1} day.", Name, Answer);
            Console.WriteLine("I will be {0} mine!", Enjoy);
        }
    }
}
