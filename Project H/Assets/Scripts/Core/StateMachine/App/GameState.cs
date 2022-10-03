using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.StateMachine.States
{
    public class GameState : BaseState
    {
        public GameState(int id, StateMachine stateMachine) : base(id, stateMachine)
        {
        }
        
        public override void Enter()
        {
            Debug.Log($"Entered {typeof(GameState)}");
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
