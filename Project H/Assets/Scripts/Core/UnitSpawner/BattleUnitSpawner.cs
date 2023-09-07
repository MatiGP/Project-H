using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

namespace Core.UnitSpawners
{
    public class BattleUnitSpawner : UnitSpawner
    {
        [SerializeField] private UnitDataProvider _unitDataProvider = null;
        public override void SpawnUnit(int unitId, GridElement gridElement)
        {
            UnitDetails details = _unitDataProvider.GetUnitDetails(unitId);
            if (details)
            {
                Transform gridTransform = gridElement.transform;
            }
        }
    }
}
