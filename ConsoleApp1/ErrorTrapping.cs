using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class ErrorTrapping
    {
        public static void Crash()
        {
            Console.WriteLine("Divide by 0 error");
            int numerator = 10;
            for (int d = -3; d <= 3; d++)
            {
                int answer = numerator / d;
                Console.WriteLine("{0} / {1} = {2}", numerator, d, answer);
            }
        }

        public static void SafeCrash()
        {
            try
            {
                Console.WriteLine("Divide by 0 error");
                int numerator = 10;
                for (int d = -3; d <= 3; d++)
                {
                    int answer = numerator / d;
                    Console.WriteLine("{0} / {1} = {2}", numerator, d, answer);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("there was a problem");
                Console.WriteLine(error.Message);
            }
        }
    }
}
