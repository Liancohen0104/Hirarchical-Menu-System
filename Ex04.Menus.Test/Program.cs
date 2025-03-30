namespace Ex04.Menus.Test
{
    // $G$ SFN-002 (-3) Selecting an action item should clear the screen.
    public static class Program
    {
        public static void Main()
        {
            DelegateMenu  delegateMenu = new DelegateMenu();
            InterfaceMenu interfaceMenu = new InterfaceMenu();

            interfaceMenu.RunInterfaceMenu();
            delegateMenu.RunDelegateMenu();
        }
    }
}