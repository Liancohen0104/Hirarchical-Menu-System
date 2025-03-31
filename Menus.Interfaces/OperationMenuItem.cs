using System.Collections.Generic;

namespace Menus.Interfaces
{
    public class OperationMenuItem : MenuItem
    {
        private readonly int r_MenuItemId;
        private readonly List<ISelectedMenuItemListener> r_SelectedMenuItemListeners;

        public OperationMenuItem(int i_MenuItemId, string i_Title) : base(i_Title)
        {
            r_MenuItemId = i_MenuItemId;
            r_SelectedMenuItemListeners = new List<ISelectedMenuItemListener>();
        }

        public void AddSelectedMenuItemListener(ISelectedMenuItemListener i_Listener)
        {
            r_SelectedMenuItemListeners.Add(i_Listener);
        }

        public override void Select()
        {
            foreach (ISelectedMenuItemListener listener in r_SelectedMenuItemListeners)
            {
                listener.SelectedMenuItem(r_MenuItemId);
            }
        }
    }
}