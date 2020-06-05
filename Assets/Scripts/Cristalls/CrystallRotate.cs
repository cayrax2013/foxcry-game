using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystallRotate : MonoBehaviour
{
    [SerializeField] private float _angle;
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, _angle, 0);
        _angle--;
    }
}
