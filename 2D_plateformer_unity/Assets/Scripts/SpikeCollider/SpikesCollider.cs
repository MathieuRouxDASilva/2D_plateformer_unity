using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Serialization;

public class SpikesCollider : MonoBehaviour
{
    //public bool isHit = false;

    public HealthManager healthManager;
    public Player player;
    public SpikesCollider spike;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            healthManager.Damage(35);
            
            Knockback();
        }
    }
    
    
    private void Knockback()
    {
        if (player.transform.position.x > spike.transform.position.x)
        {
            player.transform.position += new Vector3(1, 0, 0);
        }
        else if (player.transform.position.x < spike.transform.position.x)
        {
            player.transform.position -= new Vector3(1, 0, 0);
        }
    }
}
