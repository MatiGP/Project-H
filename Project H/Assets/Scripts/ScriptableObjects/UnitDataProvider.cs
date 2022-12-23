using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ScriptableObjects
{
    public class UnitDataProvider : MonoBehaviour
    {
        [SerializeField] private UnitDetails[] _unitDetails = null;

        public UnitDetails GetUnitDetails(string name)
        {
            return _unitDetails.FirstOrDefault(unitDetails => unitDetails.Name == name);
        }
    }
}
