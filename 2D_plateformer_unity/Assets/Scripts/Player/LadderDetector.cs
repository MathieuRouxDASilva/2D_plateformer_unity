using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LadderDetector : MonoBehaviour
{
    // Start is called before the first frame update
    private float _vertical;
    private const float Speed = 8f;
    public bool isLadder;
    private bool _isClimbing;
    //[SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;
    //private HammerBehaviour _hammer;

    private void Update()
    {
        _vertical = Input.GetAxis("Vertical");

        if (isLadder && Mathf.Abs(_vertical) > 0)
        {
            _isClimbing = true;
        }
    }

    private void FixedUpdate()
    {
        if (_isClimbing)
        {
            //animator.SetBool("isOnALadder", true);
            rb.gravityScale = 0;
            rb.velocity = new Vector2(rb.velocity.x, _vertical * Speed);
        }
        else
        {
            //animator.SetBool("isOnALadder", false);
            rb.gravityScale = 8;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ladder"))
        {
            isLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ladder"))
        {
            isLadder = false;
            _isClimbing = false;
        }
    }
}