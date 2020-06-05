using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerJumper : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 5;
    [SerializeField] private ContactFilter2D _filter;

    private Rigidbody2D _rigidbody;
    private readonly RaycastHit2D[] _results = new RaycastHit2D[1];

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Jump()
    {
        _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (IsGrounded())
                Jump();
        }
    }

    private bool IsGrounded()
    {
        bool isGround = false;

        var hit = Physics2D.Raycast(transform.position, Vector2.down, _filter, _results, 0.5f);

        if (hit > 0)
            isGround = true;
        else
            isGround = false;

        return isGround;
    }
}
