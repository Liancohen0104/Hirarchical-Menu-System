using System;
using System.Collections.Generic;
namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly string r_MainMenuTitle;
        private readonly List<MenuItem> r_MenuItems;

        public MainMenu(string i_MainMenuTitle)
        {
            r_MainMenuTitle = i_MainMenuTitle;
            r_MenuItems = new List<MenuItem>();
        }

        public List<MenuItem> MenuItems
        {
            get
            {
                return this.r_MenuItems;
            }
        }

        public void Show()
        {
            bool userChoseExit = false;
            int  userChoice;

            while (!userChoseExit)
            {
                Console.Clear();
                printMainMenuTitle();
                printMenuItems(r_MenuItems);
                userChoice = GetValidChoiceFromUser(r_MenuItems.Count);
                Console.Clear();
                if (userChoice == 0)
                {
                    userChoseExit = true;
                }
                else
                {
                    MenuItem chosenItem = r_MenuItems[userChoice - 1];
                    chosenItem.Select();
                }
            }
        }

        private void printMainMenuTitle()
        {
            Console.WriteLine("** {0} **", r_MainMenuTitle);
            Console.WriteLine("-------------------------");
        }

        private void printMenuItems(List<MenuItem> i_MenuItems)
        {
            for (int i = 0; i < i_MenuItems.Count; ++i)
            {
                Console.WriteLine("{0}. {1}", i + 1, i_MenuItems[i].Title);
            }

            Console.WriteLine("0. Exit");
            Console.WriteLine("Please enter your choice (1-{0} or 0 to exit):", i_MenuItems.Count);
        }

        public static int GetValidChoiceFromUser(int i_MaxIndexMenuItem)
        {
            int userChoice;
            bool validInput = false;
            string input;

            do
            {
                Console.Write(">> ");
                input = Console.ReadLine();
                validInput = int.TryParse(input, out userChoice)
                             && userChoice >= 0
                             && userChoice <= i_MaxIndexMenuItem;
                if (!validInput)
                {
                    Console.WriteLine("Invalid input, please try again");
                }
            }
            while (!validInput);

            return userChoice;
        }
    }
}
