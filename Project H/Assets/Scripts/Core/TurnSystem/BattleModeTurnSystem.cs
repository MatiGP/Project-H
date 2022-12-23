using System.Collections;
using System.Collections.Generic;
using Core.Combat;
using Core.Combat.Unit;
using UnityEngine;

namespace Core.TurnSystem
{
    public class BattleModeTurnSystem : TurnSystem
    {
        private TurnHolder<BattleGameUnit> _battleUnitsTurnHolder = null;
        
        public override void Initialize()
        {
            _battleUnitsTurnHolder = new TurnHolder<BattleGameUnit>();
        }

        
    }
}
