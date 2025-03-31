using System;

namespace Menus.Test
{
    public class ActionsExecutable
    {
        public static void showVersion()
        {
            Console.WriteLine("App Version: 25.1.4.5480");
        }

        public static void countLowercase()
        {
            int count = 0;
            string userInput;

            Console.WriteLine("Please enter a sentence:");
            userInput = Console.ReadLine();
            foreach (char c in userInput)
            {
                if (char.IsLower(c))
                {
                    ++count;
                }
            }

            Console.WriteLine("There are {0} lowercase letters.", count);
        }

        public static void ShowTime()
        {
            Console.WriteLine("Current Time: " + DateTime.Now.ToShortTimeString());
        }

        public static void ShowDate()
        {
            Console.WriteLine("Current Date: " + DateTime.Now.ToShortDateString());
        }
    }
}
