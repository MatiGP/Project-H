using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.TurnSystem
{
    public abstract class TurnSystem : MonoBehaviour
    {
        public event Action OnTurnStart;
        public event Action OnTurnEnd;

        public abstract void Initialize();
    }
}
