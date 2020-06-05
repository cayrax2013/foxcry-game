using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondCollisionHandler : MonoBehaviour
{
    [SerializeField] private int _score = 1;
    [SerializeField] private AudioSource _pickedUpADiamondSound;
    [SerializeField] private BoxCollider2D _collider;

    private Object _explosion;

    private void Start()
    {
        _explosion = Resources.Load("DiamondExplosion");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Score score))
        {
            score.Take(_score);
            _pickedUpADiamondSound.Play();
            _collider.enabled = false;

            var explosion = (GameObject)Instantiate(_explosion);
            explosion.transform.position = new Vector2(transform.position.x, transform.position.y);

            Destroy(gameObject);
        }
    }
}
