using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] private string _pattern = "{0}";
    [SerializeField] private Text _display;

    public void Display(int score)
    {
        _display.text = string.Format(_pattern, score);
    }
}
