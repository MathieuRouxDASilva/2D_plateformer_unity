using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathLimitBehavior : MonoBehaviour
{

    public HealthManager _healthManager;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _healthManager.Damage(100);
        }
    }
}
