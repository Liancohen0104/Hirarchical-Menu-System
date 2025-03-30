namespace Ex04.Menus.Test
{
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