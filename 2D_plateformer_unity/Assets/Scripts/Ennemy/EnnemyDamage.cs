using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyDamage : MonoBehaviour
{
    public HealthManager healthManager;
    public Player player;
    public EnnemyBehavior ennemy;
    
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
        if (player.transform.position.x > ennemy.transform.position.x)
        {
            player.transform.position += new Vector3(5, 0, 0);
        }
        else if (player.transform.position.x < ennemy.transform.position.x)
        {
            player.transform.position -= new Vector3(5, 0, 0);
        }
    }
}
