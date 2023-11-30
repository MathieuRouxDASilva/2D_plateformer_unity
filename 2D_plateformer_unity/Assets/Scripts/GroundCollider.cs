using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GroundCollider : MonoBehaviour
{
    public bool isGrounded = false;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
