using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.StateMachine.States
{
    public class GameState : BaseState
    {
        private StateMachine _gameStateMachine = null;
        
        public GameState(int id, StateMachine stateMachine) : base(id, stateMachine)
        {
        }
        
        public override void Enter()
        {
            Debug.Log($"Entered {typeof(GameState)}");
            _gameStateMachine = new StateMachine();
            _gameStateMachine.Initialize();
            _gameStateMachine.AddState(new AdventureState((int)EGameState.Adventure, _gameStateMachine));
            _gameStateMachine.AddState(new GameBattleState((int)EGameState.Battle, _gameStateMachine));
            _gameStateMachine.SwitchToState((int)EGameState.Battle);
        }

        public override void Update()
        {
            _gameStateMachine.UpdateState();
        }

        public override void FixedUpdate()
        {
            _gameStateMachine.FixedUpdateState();
        }

        public override void Exit()
        {
            _gameStateMachine.LeaveState();
        }
    }
}
