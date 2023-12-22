using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    //private int _coinNumber;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            CoinHUD.CoinAmount += 1;
        }
    }
}
