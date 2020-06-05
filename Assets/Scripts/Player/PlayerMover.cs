using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed = 5;

    private bool _facingRight = true;
    private float _moveX;

    private void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            Movement();
        }

        if (_moveX < 0 && _facingRight)
            Flip();
        else if (_moveX > 0 && !_facingRight)
            Flip();
    }

    private void Movement()
    {
        _moveX = Input.GetAxis("Horizontal");
        _rigidbody.velocity = new Vector2(_moveX * _speed, _rigidbody.velocity.y);
    }

    private void Flip()
    {
        _facingRight = !_facingRight;

        transform.Rotate(0, 180, 0);
    }
}
