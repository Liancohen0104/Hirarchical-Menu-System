using System;
using System.Collections.Generic;
namespace Ex04.Menus.Interfaces
{
    public class SubMenuItem : MenuItem
    {
        private readonly List<MenuItem> r_SubMenuItemsList;

        public SubMenuItem(string i_Title) : base(i_Title)
        {
            r_SubMenuItemsList = new List<MenuItem>();
        }

        public List<MenuItem> SubMenuItemsList
        {
            get
            {
                return this.r_SubMenuItemsList;
            }
        }

        public override void Select()
        {
            bool backRequested = false;
            int userChoice;

            while (!backRequested)
            {
                Console.WriteLine($"** {Title} **");
                Console.WriteLine("-------------------------");
                for(int i = 0; i < r_SubMenuItemsList.Count; ++i)
                {
                    Console.WriteLine($"{i + 1}. {r_SubMenuItemsList[i].Title}");
                }

                Console.WriteLine("0. Back");
                userChoice = MainMenu.GetValidChoiceFromUser(r_SubMenuItemsList.Count);
                if(userChoice == 0)
                {
                    backRequested = true;
                    Console.Clear();
                }
                else
                {
                    if(r_SubMenuItemsList[userChoice - 1] is SubMenuItem)
                    {
                        Console.Clear();
                    }

                    r_SubMenuItemsList[userChoice - 1].Select();
                }
            }
        }
    }
}