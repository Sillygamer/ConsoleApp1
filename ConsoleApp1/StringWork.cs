using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class StringWork
    {
        public static void StringFeatures()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("needed to enter text");
            }
            else
            {
                Console.WriteLine("Thanks You entered \"{0}\"", text);
                string query = text.StartsWith("C#") ? "Does" : "Does Not";
                Console.WriteLine("{0}{1} start with C#", text, query);
                query = text.EndsWith("cool.") ? "Does" : "Does Not";
                Console.WriteLine("{0} {1} end with cool.", text, query);
                query = text.Contains(" is ") ? "Does" : "does not";
                Console.WriteLine("{0} {1} contains is", text, query);

            }
        }

        public static void Manipulate()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Thanks You entered \"{0}\"", text);
            Console.WriteLine("Your txt is {0} long",text.Length);
            text = text.Trim();
            Console.WriteLine("Your trimmed txt is {0} long", text.Length);
            string upper = text.ToUpper();
            string lower = text.ToLower();
            Console.WriteLine(lower);
            Console.WriteLine(upper);
            string huh = text.ToLowerInvariant();
            Console.WriteLine(huh);
            text = text.PadLeft(10, '*');
            Console.WriteLine(text);
            text = text.PadRight(30, '1');
            Console.WriteLine(text);
            //trin start trim end
        }

        public static void JoinAndCompare()
        {
            string[] a = new string[3] { "Alpha", "Beta", "Gamma" };
            string s = String.Concat(a[0], a[2]);
            Console.WriteLine(s);
            s = a[0] + a[1];
            Console.WriteLine(s);
            s = String.Join(" ",a[0], a[2], a[1]);
            Console.WriteLine(s);
            s = String.Join(" ", a);
            Console.WriteLine(s);

            int num = String.Compare("apples", "oranges");
            Console.WriteLine(num);

            Console.WriteLine("apples" == "oranges");
        }

        public static void FindingSubStrings()
        {
            string phrase = "The quik brown fox jumped over the lazy dog and the cat and the mouse.".ToLower();
            string SearchTerm = "fox";
            int num = phrase.IndexOf(SearchTerm,1);
            Console.WriteLine(num);

        }

        public static void Formatting()
        {
            // g general f fixed point n= number with commas at thousands
            // c currency p percent 000.00000 zero padding
            float number = 2.567f;
            string sn = number.ToString("N");
            Console.WriteLine(sn);

            string data = "Alpha,Bravo,Charlie,Delta,Echo,Foxtrot,unicorn,andrea";
            string DATA = "Sentence is amazing unicorns popsices";
            string[] itens2 = data.Split(' ');
            string[] items = data.Split(',');
           // Console.WriteLine(items[3]);
            foreach(string item in items)
            {
                Console.WriteLine(item);
            }
            foreach (string item2 in itens2)
            {
                Console.WriteLine(item2);
            }
        }
        public static void DateStrings()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.DayOfWeek);
            Console.WriteLine(now.DayOfYear);
            Console.WriteLine(now.Month);
            Console.WriteLine(now.Year);
            Console.WriteLine(Convert.ToString(now.ToBinary()));

            DateTime birthday = new DateTime(2002, 06, 10);
            Console.WriteLine(birthday.DayOfWeek);
            Console.WriteLine(birthday.DayOfYear);
            Console.WriteLine(birthday.Month);
            Console.WriteLine(birthday.Year);
            Console.WriteLine(birthday);
            Console.WriteLine(birthday.AddYears(50).DayOfWeek);
        }

        public static void HomeWorkChallenge()
        {
            while (true)
            {
                Console.WriteLine("Enter Name: ");
                string FirstName = Console.ReadLine().Trim();

                if (FirstName.Length >= 11)
                {
                    Console.WriteLine("It must be 10 characters or less");
                }
                else
                {
                    Console.WriteLine("Thanks");
                    FirstName.ToUpper();
                    Console.WriteLine("{0}", FirstName);
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Create a name: ");
                string SecondName = Console.ReadLine().Trim();
                if (SecondName.StartsWith('Z'))
                {
                    Console.WriteLine("Thanks");
                    SecondName.ToLower();
                    Console.WriteLine("{0}", SecondName);
                    break;
                }
                else
                {
                    Console.WriteLine("Must start with a capital Z");
                }
               
            }
            string[] separatingStrings = {","};
            Console.WriteLine("Make a list of weapons, dont forget the commas.");
            String Weapons = Console.ReadLine().Trim();
            string[] wps = Weapons.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            System.Console.WriteLine($"{wps.Length} substrings in text:");

            foreach (var word in wps)
            {
                System.Console.WriteLine(word);
            }
            Console.WriteLine("What year were you born?");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your birth month?");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the day of your birthday?");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime birthday = new DateTime(year, month, day);
            Console.WriteLine(birthday.DayOfWeek);

            Console.WriteLine("enter world name ");
            string world = Console.ReadLine().Trim();
            for (int i = 0; i < world.Length; i++)
            {
                string letter = world.Substring(i, 1);
                string Answer = (i % 2 == 0) ? letter.ToUpper() : letter.ToLower();
                Console.Write(Answer);
            }


        }

    }
   
}
