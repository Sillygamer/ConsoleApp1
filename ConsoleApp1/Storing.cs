using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Storing
    {

        //first method
        public static void Initialize()
        {
            Console.WriteLine("Hi");
            Console.WriteLine("C# BOOTCAMP INITIALIZED");
        }//end of initialize
        public static void Demovariables()
        {
            int playerNumber = 444;
            uint PlayerHealth = 555;
            ulong PlayerMoney = 477282739847;
            float pi = 3.14f;
            Console.WriteLine(pi);
            bool isRich = true;
            string playerName = "Andrea";

            char firstIntital = 'A';
            //firstIntital++;

            Console.WriteLine(firstIntital);
            /*
            char beep = (char)7;
            Console.WriteLine(beep);
            
            while (true)
            {
                Console.WriteLine(beep);
                beep++;
                Console.ReadLine();
            }
            */

        }
        public static void ReadingInput()
        {
            Console.Write("Enter Player name:> ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}. It is good to have you here adventurer.", name);
            Console.Write("Enter your age:> ");
            int age = Convert.ToInt32(Console.ReadLine());
            int ageInMonths = age * 12;
            Console.WriteLine("Thank you. you are {0} months old", ageInMonths);
        }
        public static void UsingArrays()
        {
            string[] enemyName = new string[5];
            enemyName[0] = "Riley";
            enemyName[1] = "Joseph";
            enemyName[2] = "Andrea";
            enemyName[3] = "Ron";
            enemyName[4] = "Nathan";

            int[] enemyHealth = new int[5] { 10, 30, 35, 2, 90 };

            System.Random random = new System.Random();
            while (true)
            {
                int num = random.Next(5);
                Console.WriteLine("Rolled a {0}", num);
                enemyHealth[num]--;
                Console.WriteLine("{0} has {1} health and just charged at you", enemyName[num], enemyHealth[num]);
                Console.ReadLine();
            }
        }

    }//end of storing
}
