using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

namespace Core.UnitSpawners
{
    public abstract class UnitSpawner : MonoBehaviour
    {
        public abstract void SpawnUnit(int unitID, GridElement gridElement);
    }
}
