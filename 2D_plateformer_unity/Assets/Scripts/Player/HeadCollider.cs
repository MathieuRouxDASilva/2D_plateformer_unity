
using UnityEngine;


public class EnnemyCollider : MonoBehaviour
{
    //private bool _isStomped = false;

    public int nbDestroyed = 0;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ennemy"))
        {
            Destroy(other.gameObject);
            nbDestroyed++;
        }
    }

    // private void OnCollisionExit2D(Collision2D other)
    // {
    //     if (other.gameObject.CompareTag("Player"))
    //     {
    //         _isStomped = false;
    //     }
    // }




}