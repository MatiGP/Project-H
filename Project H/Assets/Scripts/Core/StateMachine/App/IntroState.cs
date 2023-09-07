using System.Collections;
using System.Collections.Generic;
using UI;
using UI.UIPanels;
using UnityEngine;

namespace Core.StateMachine.States
{
    public class IntroState : BaseState
    {
        private SplashScreenPanel _splashScreenPanel = null;
        
        public IntroState(int id, StateMachine stateMachine) : base(id, stateMachine)
        {
        }
        
        public override void Enter()
        {
            _splashScreenPanel = UIManager.Instance.CreatePanel(EPanelID.SplashScreen) as SplashScreenPanel;
            _splashScreenPanel.OnFadeCompleted += HandleSplashCompleted;
        }

        private void HandleSplashCompleted()
        {
            _parent.SwitchToState((int)EAppState.Menu);
        }

        public override void Update()
        {
            
        }

        public override void FixedUpdate()
        {
            
        }

        public override void Exit()
        {
            
        }
    }
}
