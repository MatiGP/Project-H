using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    public abstract class UnitDetails : ScriptableObject
    {
        public GameObject UnitModel => _unitModel;
        public Sprite Icon => _icon;
        public string Name => _name;
        public int ID => _id;
        
        [SerializeField] protected GameObject _unitModel = null;
        [SerializeField] protected Sprite _icon = null;
        [SerializeField] protected string _name = null;
        [SerializeField] protected int _id = -1;
    }
}
