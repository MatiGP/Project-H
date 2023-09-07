using System;
using System.Collections;
using System.Collections.Generic;
using Core.TurnSystem;
using Core.UnitSpawners;
using UnityEngine;

namespace Core.GameInstance
{
    public class BattleModeController : MonoBehaviour
    {
        [SerializeField] private BattleGrid _grid = null;
        [SerializeField] private BattleUnitSpawner _unitSpawner = null;

        private void Awake()
        {
            Activate();
        }


        public void Activate()
        {
            _grid.PrepareGrid();
        }
    }
}
