using System.Collections;
using System.Collections.Generic;
using UI;
using UI.UIPanels;
using UnityEngine;

namespace Core.StateMachine.States
{
    public class MenuState : BaseState
    {
        private MainMenuPanel _mainMenuPanel = null;
        
        public MenuState(int id, StateMachine stateMachine) : base(id, stateMachine)
        {
        }
        
        public override void Enter()
        {
            _mainMenuPanel = UIManager.Instance.CreatePanel(EPanelID.MainMenu) as MainMenuPanel;
            if (_mainMenuPanel)
            {
                _mainMenuPanel.OnPlayGame += HandlePlayGame;
            }
        }

        private void HandlePlayGame()
        {
            _parent.SwitchToState((int)EAppState.Game);
        }

        public override void Update()
        {
        }

        public override void FixedUpdate()
        {
        }

        public override void Exit()
        {
            if (_mainMenuPanel)
            {
                _mainMenuPanel.OnPlayGame -= HandlePlayGame;
            }
            
            _mainMenuPanel.Close();
        }
    }
}
