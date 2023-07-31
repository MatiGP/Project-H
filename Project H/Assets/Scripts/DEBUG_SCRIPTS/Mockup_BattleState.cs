using System;
using System.Collections;
using System.Collections.Generic;
using Core.Combat.Unit;
using ScriptableObjects;
using UnityEngine;

public class Mockup_BattleState : MonoBehaviour
{
    [SerializeField] private List<BattleUnitDetails> _enemyArmy = new List<BattleUnitDetails>();
    [SerializeField] private List<BattleUnitDetails> _allyArmy = new List<BattleUnitDetails>();

    [SerializeField] private BattleGameUnit _gameUnitPrefab = null;

    [SerializeField] private Transform _allyUnitHolder = null;
    [SerializeField] private Transform _enemyUnitHolder = null;

    private const float UNIT_OFFSET = 10f;
    private Vector3 _offset = Vector3.left * UNIT_OFFSET;

    private void Awake()
    {
        SpawnUnits(_enemyArmy, true);
        SpawnUnits(_allyArmy, false);
    }

    private void SpawnUnits(List<BattleUnitDetails> units, bool isEnemy)
    {
        Vector3 unitPosition = Vector3.zero;

        for (int i = 0; i < units.Count; i++)
        {
            BattleGameUnit unit = Instantiate(_gameUnitPrefab, isEnemy ? _enemyUnitHolder : _allyUnitHolder);
            unit.Initialize(units[i]);
            unit.transform.localPosition = unitPosition;
            unitPosition += _offset;
        }
    }
}
