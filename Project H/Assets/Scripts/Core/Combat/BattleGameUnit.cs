using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using TMPro;
using UnityEngine;

namespace Core.Combat.Unit
{
    public class BattleGameUnit : GameUnit
    {
        private BattleUnitDetails _battleUnitDetails = null;
        [SerializeField] private TextMeshPro _detailsText = null;
        [SerializeField] private SpriteRenderer _unitIcon = null;
        
        public override void Initialize(UnitDetails unitDetails)
        {
            _battleUnitDetails = unitDetails as BattleUnitDetails;
            
            _detailsText.text = _battleUnitDetails.ToString();
            _unitIcon.sprite = _battleUnitDetails.Icon;
        }
        
        public override void Move(Vector2 position)
        {
            
        }
    }
}
