using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    public abstract class UnitDetails : ScriptableObject
    {
        public Sprite Icon => _icon;
        public string Name => _name;
        
        [SerializeField] protected Sprite _icon = null;
        [SerializeField] protected string _name = null;
    }
}
