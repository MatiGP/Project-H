using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "Unit Details/Battle Unit")]
    public class BattleUnitDetails : UnitDetails
    {
        public int Hp => _hp;
        public int Atc => _atc;
        public int Def => _def;
        public int Mana => _mana;
        public int Speed => _speed;
        public int Prio => _prio;
        
        [SerializeField] private int _hp = -1;
        [SerializeField] private int _atc = -1;
        [SerializeField] private int _def = -1;
        [SerializeField] private int _mana = -1;
        [SerializeField] private int _speed = -1;
        [SerializeField] private int _prio = -1;

        public override string ToString()
        {
            return $"NAME : {_name}\n" +
                   $"HP : {_hp} \n" +
                   $"ATC : {_atc} \n" +
                   $"DEF : {_def} \n" +
                   $"MANA : {_mana} \n" +
                   $"SPEED : {_speed} \n" +
                   $"PRIO : {_prio}";
        }
    }
}
