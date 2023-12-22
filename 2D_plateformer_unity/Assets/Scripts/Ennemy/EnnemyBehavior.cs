using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnnemyBehavior : MonoBehaviour
{
    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    private GroundCollider _groundCollider;
    private int _direction = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _groundCollider = GetComponentInChildren<GroundCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        SetuppMouvement();

        FlipSprite();
    }

    private void SetuppMouvement()
    {
        _rb.velocity += new Vector2(1, 0) * _direction;
        //Debug.Log(_direction);

        if (_rb.velocityX > 5)
        {
            _rb.velocityX = 5;
        }
        else if (_rb.velocityX < -5)
        {
            _rb.velocityX = -5;
        }

        if (_groundCollider.isGrounded)
        {
            if (_direction == 1)
            {
                _direction = -1;
            }
            else if (_direction == -1)
            {
                _direction = 1;
            }
            //Debug.Log(_direction);
        }
    }

    private void FlipSprite()
    {
        if (_rb.velocity.x <= -0.1f)
        {
            _sr.flipX = true;
        }
        else if (_rb.velocity.x >= 0.1f)
        {
            _sr.flipX = false;
        }
    }
}
