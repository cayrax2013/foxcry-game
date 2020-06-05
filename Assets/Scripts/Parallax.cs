using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private GameObject _camera;
    [SerializeField] private float _parallaxEffect;

    private float _length;
    private float _startPos;

    private void Start()
    {
        _startPos = transform.position.x;
        _length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void FixedUpdate()
    {
        float temp = (_camera.transform.position.x * (1 - _parallaxEffect));
        float distance = (_camera.transform.position.x * _parallaxEffect);

        transform.position = new Vector3(_startPos + distance, transform.position.y, transform.position.z);

        if (temp > _startPos + _length - 10)
            _startPos += _length;
        else if (temp < _startPos - _length + 1f)
            _startPos -= _length; 
    }
}
