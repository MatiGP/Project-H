using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleGrid : MonoBehaviour
{
    [SerializeField] private GridElement gridPrefab = null;

    private Dictionary<Vector3, GridElement> _gridElements = new Dictionary<Vector3, GridElement>();

    private const int ROWS = 12;
    private const int COLS = 14;
    private const float OFFSET = 1f;
    private Vector3 gridOrigin = new Vector3(0.5f, 0f, 0.5f);
    
    public void PrepareGrid()
    {
        Vector3 cords = gridOrigin;
        
        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < COLS; j++)
            {
                cords.x = gridOrigin.x + j * OFFSET;
                cords.z = gridOrigin.z + i * OFFSET;
                
                GridElement element = Instantiate(gridPrefab,
                    cords,
                    gridPrefab.transform.rotation,
                    transform);
                _gridElements.Add(cords, element);
                
                element.OnSelect += HandleGridElementSelected;
            }
        }
    }

    private void HandleGridElementSelected(Vector3 position)
    {
        Debug.Log($"Selected grid element on : {position}");
    }
}
