using System.Collections.ObjectModel;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public CoinManager _coinManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy(gameObject);
       //gameObject.SetActive(false);
       _coinManager.Collect(this);
    }
}
