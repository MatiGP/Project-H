using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "ScriptableObjects/UnitDataProvider", fileName = "Unit Data Provider")]
    public class UnitDataProvider : ScriptableObject
    {
        [SerializeField] private UnitDetails[] _unitDetails = null;

        public UnitDetails GetUnitDetails(int id)
        {
            UnitDetails details = _unitDetails.FirstOrDefault(unitDetails => unitDetails.ID == id);

            if (details)
            {
                return details;
            }
            
            Debug.LogError($"UNIT DETAILS WITH ID {id} DOES NOT EXIST. \n" +
                           $" MAKE SURE DETAILS ARE ADDED TO ARRAY INSIDE UNIT DATA PROVIDER");
            return _unitDetails[0];
        }
    }
}
