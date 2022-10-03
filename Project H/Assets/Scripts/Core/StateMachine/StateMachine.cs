using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

namespace Core.StateMachine
{
    public class StateMachine
    {
        private BaseState _currentState = null;

        private Dictionary<int, BaseState> _availableStates = null;

        public void Initialize()
        {
            _availableStates = new Dictionary<int, BaseState>();
        }

        public void AddState(BaseState state)
        {
            _availableStates.Add(state.ID, state);
        }

        public void SwitchToState(int id)
        {
            if (_availableStates.ContainsKey(id))
            {
                if (_currentState != null)
                {
                    _currentState.Exit();
                    _currentState = null;
                   
                }
                
                _currentState = _availableStates[id];
                _currentState.Enter();
            }
            else
            {
                Debug.LogError($"STATE WITH ID {id} DOES NOT EXIST");
            }
        }

        public void UpdateState()
        {
            if (_currentState != null)
            {
                _currentState.Update();
            }
        }

        public void FixedUpdateState()
        {
            if (_currentState != null)
            {
                _currentState.FixedUpdate();
            }
        }
    }
}
