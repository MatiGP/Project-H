using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

namespace Core.Combat.Unit
{
    public abstract class GameUnit : MonoBehaviour
    {
        public abstract void Initialize(UnitDetails unitDetails);
        public abstract void Move(Vector2 position);
    }
}
