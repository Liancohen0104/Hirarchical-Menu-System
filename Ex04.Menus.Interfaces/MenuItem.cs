namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private readonly string r_Title;

        public MenuItem(string i_Title)
        {
            this.r_Title = i_Title;
        }

        public string Title
        {
            get
            {
                return this.r_Title;
            }
        }

        public abstract void Select();
    }
}