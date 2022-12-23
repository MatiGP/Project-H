using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.StateMachine
{
    public abstract class BaseState
    {
        public int ID => _id;
        
        protected int _id = 0;
        protected StateMachine _parent = null;

        public BaseState(int id, StateMachine parent)
        {
            _id = id;
            _parent = parent;
        }
        
        public abstract void Enter();
        public abstract void Update();
        public abstract void FixedUpdate();
        public abstract void Exit();
    }
}
