using System.Collections;
using System.Collections.Generic;
using UI;
using UI.UIPanels;
using UnityEngine;

// Setup, Move around units etc.

namespace Core.StateMachine.States
{
    public class TacticState : BaseState
    {
        private TacticModePanel _tacticModePanel = null;
        
        public TacticState(int id, StateMachine parent) : base(id, parent)
        {
        }

        public override void Enter()
        {
            _tacticModePanel = UIManager.Instance.CreatePanel(EPanelID.TacticMode) as TacticModePanel;
            BindEvents();
        }

        public override void Update()
        {
            
        }

        public override void FixedUpdate()
        {
           
        }

        public override void Exit()
        {
            UnBindEvents();
        }

        private void BindEvents()
        {
            _tacticModePanel.OnTacticModeFinished += HandleTacticModeFinished;
        }

        private void UnBindEvents()
        {
            _tacticModePanel.OnTacticModeFinished -= HandleTacticModeFinished;
        }
        
        private void HandleTacticModeFinished()
        {
            _parent.SwitchToState((int)EBattleState.Battle);
        }
    }
}
