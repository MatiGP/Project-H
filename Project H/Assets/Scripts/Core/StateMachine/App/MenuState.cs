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
            Debug.Log($"Entered {typeof(MenuState)}");
            _mainMenuPanel = UIManager.Instance.CreatePanel(EPanelID.MainMenu) as MainMenuPanel;
        }

        public override void Update()
        {
            throw new System.NotImplementedException();
        }

        public override void FixedUpdate()
        {
            throw new System.NotImplementedException();
        }

        public override void Exit()
        {
            throw new System.NotImplementedException();
        }
    }
}
