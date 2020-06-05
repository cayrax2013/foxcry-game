using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventInt : UnityEvent<int> { }

public class Score : MonoBehaviour
{
    [SerializeField] private UnityEventInt _scoreChanged;
    [SerializeField] private int _current = 0;

    public void Take(int score)
    {
        _current += score;

        _scoreChanged?.Invoke(_current);
    }
}
