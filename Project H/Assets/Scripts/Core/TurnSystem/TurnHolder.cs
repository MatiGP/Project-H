using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnHolder<T> where T : Object
{
    private List<T> _turns = new List<T>();

    public void AddTurn(T unit)
    {
        _turns.Add(unit);
    }

    public T PeekTurn(int turnIndex)
    {
        if (IsTurnIndexValid(turnIndex))
        {
            return _turns[turnIndex];
        }
        else
        {
            return null;
        }
    }

    public void RemoveFromTurn(T unit)
    {
        _turns.Remove(unit);
    }

    private bool IsTurnIndexValid(int index)
    {
        return index >= 0 && index < _turns.Count;
    }
}