using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Statements
    {
        public static void Branching1()
        {
            int a = 7;

            if (a < 4)
            {
                Console.WriteLine("Number is less than 4");
            }
            else if (a >= 4 && a < 10)
            {
                Console.WriteLine("Number is between 4 and 10");
            }
            else
            {
                Console.WriteLine("Greater than 10");
            }
            int b = 10;
            if (b > 5) Console.WriteLine("b is bigger than 5");

        }//end
        public static void Switching()
        {
            int d = 2 % 7;
            string day = "";

            switch (d)
            {
                case 1:
                    day = "monday";
                    break;
                case 2:
                    day = "tuesday";
                    break;
                case 3:
                    day = "wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "friday";
                    break;
                case 6:
                    day = "saturday";
                    break;
                case 7:
                    day = "Sunday";
                    break;
                default:
                    day = "world end";
                    break;

            }
            Console.WriteLine("Day {0} is {1}", d, day);
        }//end of switching
        public static void ForLoop()
        {
            for (int i = 2; i <= 14; i += 2)
            {
                Console.WriteLine("The value of i is {0}", i);
            }//end of for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Outer loop {0}", i);
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("inner loop {0}", j);
                }
            }
        }//end of forloop
        public static void WhileLoops()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("The value of i is {0}", i);
                i++;
            }//end of while

            int j = 0;
            do
            {
                Console.WriteLine("the number of j is{0}", j);
                j++;
            } while (j < 5);
            do
            {
                Console.WriteLine("command> ");
            } while (Console.ReadLine() != "q");
        }//end of while loops
        public static void LoopingArrays()
        {
            string[] monster = new string[4];
            monster[0] = "fred";
            monster[1] = "george";
            monster[2] = "ron";
            monster[3] = "bob";
            for (int q = 0; q < 4; q++)
            {
                Console.WriteLine("\t{0}", monster[q]);
            }
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine("\t{0}", monster[i]);
            }
        }//end of looping arrays
        public static void ForEachIterations()
        {
            List<string> phones = new List<string>();
            phones.Add("IPhone 12");
            phones.Add("Google pixel");
            phones.Add("Motorola Stylus");
            phones.Add("Nokia flip phone");
            phones.Add("One Plus");

            foreach (string p in phones)
            {
                Console.WriteLine("\t{0}", p);
            }
        }
    }
}
