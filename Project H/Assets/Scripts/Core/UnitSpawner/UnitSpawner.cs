using System.Collections;
using System.Collections.Generic;
using Core.Combat.Unit;
using ScriptableObjects;
using UnityEngine;

namespace Core.UnitSpawners
{
    public abstract class UnitSpawner : MonoBehaviour
    {
        public abstract void SpawnUnits(List<string> unitNames, Vector3 position);
        public abstract void SpawnUnit(string unitName, Vector3 position);
        public abstract void SpawnHero(string heroName, Vector3 position);
    }
}
