using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
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
                return r_MenuItems;
            }
        }

        public void Show()
        {
            bool userChoseExit = false;

            while (!userChoseExit)
            {
                Console.Clear();
                printMainMenuTitle();
                printMenuItems(r_MenuItems);
                int userChoice = getValidChoiceFromUser(r_MenuItems.Count);
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

        // $G$ DSN-001 (-3) The main menu should not be responsible for managing the sub menu input / output.
        private void printMenuItems(List<MenuItem> i_MenuItems, bool i_IsMainMenu = true)
        {
            for (int i = 0; i < i_MenuItems.Count; ++i)
            {
                Console.WriteLine("{0}. {1}", i + 1, i_MenuItems[i].Title);
            }

            if (i_IsMainMenu)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("Please enter your choice (1-{0} or 0 to exit):", i_MenuItems.Count);
            }
            else
            {
                Console.WriteLine("0. Back");
                Console.WriteLine("Please enter your choice (1-{0} or 0 to go back):", i_MenuItems.Count);
            }
        }

        private int getValidChoiceFromUser(int i_MaxIndexMenuItem)
        {
            int userChoice;
            bool validInput = false;

            do
            {
                Console.Write(">> ");
                string input = Console.ReadLine();
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