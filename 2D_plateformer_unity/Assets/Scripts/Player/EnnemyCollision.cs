using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class EnnemyCollision : MonoBehaviour
{
    public HealthManager healthManager;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ennemy"))
        {
            healthManager.Damage(35);
        }
    }
}
