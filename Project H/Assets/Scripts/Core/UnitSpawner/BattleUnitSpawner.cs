using System.Collections;
using System.Collections.Generic;
using Core.Combat.Unit;
using ScriptableObjects;
using UnityEngine;

namespace Core.UnitSpawners
{
    public class BattleUnitSpawner : UnitSpawner
    {
        [SerializeField] private UnitDataProvider _unitDataProvider = null;
        [SerializeField] private BattleGameUnit _battleUnitPrefab = null;
        [SerializeField] private HeroGameUnit _heroUnitPrefab = null;
        
        public override void SpawnUnits(List<string> unitNames, Vector3 position)
        {
            unitNames.ForEach(unitName =>
            {
                UnitDetails details = _unitDataProvider.GetUnitDetails(unitName);
                if (details)
                {
                    BattleGameUnit gameUnit = Instantiate(_battleUnitPrefab, position, Quaternion.identity);
                    gameUnit.Initialize(details);
                }
            });
        }

        public override void SpawnUnit(string unitName, Vector3 position)
        {
            UnitDetails details = _unitDataProvider.GetUnitDetails(unitName);
            if (details)
            {
                BattleGameUnit gameUnit = Instantiate(_battleUnitPrefab, position, Quaternion.identity);
                gameUnit.Initialize(details);
            }
        }

        public override void SpawnHero(string heroName, Vector3 position)
        {
            UnitDetails details = _unitDataProvider.GetUnitDetails(heroName);
            if (details)
            {
                HeroGameUnit gameUnit = Instantiate(_heroUnitPrefab, position, Quaternion.identity);
                gameUnit.Initialize(details);
            }
        }
        
    }
}
