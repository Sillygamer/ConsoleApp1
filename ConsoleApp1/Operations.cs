using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Operations
    {
        public static void Arithmatic()
        {
            int a = 9;
            int b = 6;
            int c;

            a++;
            b--;

            c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;

            c = a % b;


            a += b;
            a -= b;
            a *= b;
            a /= b;

            a /= 7;
            Console.WriteLine("\n" + a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
        public static void Comparison()
        {
            int a = 10;
            int b = 42;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
        }

        public static void Logic()
        {
            bool hasSword = true;
            bool hasMagic = false;

            if (hasMagic) Console.WriteLine("Has a magic amulet");
            if (!hasMagic) Console.WriteLine("does not have a magic amulet");
            if (hasSword) Console.WriteLine("Has a sword");
            if (!hasSword) Console.WriteLine("has no sword");
            if (hasMagic && hasSword) Console.WriteLine("very dangerous has magic amulet and weapon!");
            if (hasMagic || hasSword) Console.WriteLine("can attack with magic or sword");
            if (hasMagic ^ hasSword) Console.WriteLine("Only has One form of attack");
            if (!hasSword && !hasMagic) Console.WriteLine("Has no form of an attack...RUN!");

        }

        public static void Ternary()
        {
            int a = 18;
            int b = 42;
            int c;

            c = (a == b) ? a : b;
            Console.WriteLine(c);

            string Answer = (a % 2 == 0) ? "even" : "odd";
            Console.WriteLine("{0} is {1}", a, Answer);
        }
    }
}
