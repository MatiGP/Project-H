using System.Collections.Generic;

namespace UI
{
    public class UIGlobalLayer
    {
        private List<EPanelID> _panelOrder = new List<EPanelID>()
        {
            // Menu
            EPanelID.SplashScreen,
            EPanelID.MainMenu,
            
            // Gameplay
            EPanelID.TacticMode
        };

        public List<EPanelID> PanelOrder => _panelOrder;
    }
}
