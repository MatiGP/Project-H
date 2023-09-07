using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// actual battle

namespace Core.StateMachine.States
{
    public class GameBattleState : BaseState
    {
        private StateMachine _battleStateMachine = null;
        
        public GameBattleState(int id, StateMachine parent) : base(id, parent)
        {
        }

        public override void Enter()
        {
            GameApp.Instance.LevelLoader.LoadLevel(ESceneName.BattleMap);
            _battleStateMachine = new StateMachine();
            InitializeBattleStateMachine();
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

        private void InitializeBattleStateMachine()
        {
            _battleStateMachine.Initialize();
            _battleStateMachine.AddState(new PreparationState((int)EBattleState.Preparation, _battleStateMachine));
            _battleStateMachine.AddState(new TacticState((int)EBattleState.Tactic, _battleStateMachine));
            _battleStateMachine.AddState(new TurnBattleState((int)EBattleState.Battle, _battleStateMachine));
            _battleStateMachine.AddState(new EndBattleState((int)EBattleState.End, _battleStateMachine));
            _battleStateMachine.SwitchToState((int)EBattleState.Preparation);
        }
    }
}
