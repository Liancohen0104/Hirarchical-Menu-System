using Ex04.Menus.Interfaces;
namespace Ex04.Menus.Test
{
    public class InterfaceMenu : ISelectedMenuItemListener
    {
        public void RunInterfaceMenu()
        {
            MainMenu mainMenu = new MainMenu("Interface Main Menu");
            MenuItem lettersAndVersion = new SubMenuItem("Letters and Version");
            MenuItem actionMenuItem = new OperationMenuItem((int)eMenuItemOperation.ShowVersion, "Show Version");

            (actionMenuItem as OperationMenuItem).AddSelectedMenuItemListener(this);
            (lettersAndVersion as SubMenuItem).SubMenuItemsList.Add(actionMenuItem);
            actionMenuItem = new OperationMenuItem((int)eMenuItemOperation.CountLowercaseLetters, "Count Lowercase Letters");
            (actionMenuItem as OperationMenuItem).AddSelectedMenuItemListener(this);
            (lettersAndVersion as SubMenuItem).SubMenuItemsList.Add(actionMenuItem);
            mainMenu.MenuItems.Add(lettersAndVersion);
            MenuItem dateTimeMenu = new SubMenuItem("Show Current Date/Time");

            actionMenuItem = new OperationMenuItem((int)eMenuItemOperation.ShowCurrentTime, "Show Current Time");
            (actionMenuItem as OperationMenuItem).AddSelectedMenuItemListener(this);
            (dateTimeMenu as SubMenuItem).SubMenuItemsList.Add(actionMenuItem);
            actionMenuItem = new OperationMenuItem((int)eMenuItemOperation.ShowCurrentDate, "Show Current Date");
            (actionMenuItem as OperationMenuItem).AddSelectedMenuItemListener(this);
            (dateTimeMenu as SubMenuItem).SubMenuItemsList.Add(actionMenuItem);
            mainMenu.MenuItems.Add(dateTimeMenu);
            mainMenu.Show();
        }

        void ISelectedMenuItemListener.SelectedMenuItem(int i_ItemId)
        {
            switch ((eMenuItemOperation)i_ItemId)
            {
                case eMenuItemOperation.ShowVersion:
                    ActionsExecutable.showVersion();
                    break;
                case eMenuItemOperation.CountLowercaseLetters:
                    ActionsExecutable.countLowercase();
                    break;
                case eMenuItemOperation.ShowCurrentTime:
                    ActionsExecutable.ShowTime();
                    break;
                case eMenuItemOperation.ShowCurrentDate:
                    ActionsExecutable.ShowDate();
                    break;
            }
        }
    }
}