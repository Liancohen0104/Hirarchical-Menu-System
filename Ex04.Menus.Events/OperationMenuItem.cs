using System;

namespace Ex04.Menus.Events
{
    public class OperationMenuItem : MenuItem
    {
        private readonly int r_MenuItemId;
        public event Action<int> SelectedMenuItem;

        public OperationMenuItem(int i_MenuItemId, string i_Title) : base(i_Title)
        {
            r_MenuItemId = i_MenuItemId;
        }

        public override void Select()
        {
            if (SelectedMenuItem != null)
            {
                SelectedMenuItem.Invoke(r_MenuItemId);
            }
        }
    }
}
