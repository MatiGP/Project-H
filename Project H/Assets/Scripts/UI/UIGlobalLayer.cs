using System.Collections.Generic;

namespace UI
{
    public class UIGlobalLayer
    {
        private List<EPanelID> _panelOrder = new List<EPanelID>()
        {
            EPanelID.SplashScreen,
            EPanelID.MainMenu
        };

        public List<EPanelID> PanelOrder => _panelOrder;
    }
}
