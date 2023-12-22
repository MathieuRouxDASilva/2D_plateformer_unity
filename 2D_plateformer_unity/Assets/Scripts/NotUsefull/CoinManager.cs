using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    // Start is called before the first frame update

    public int NbCoinsCollected => _collectedCoins.Count;
    
    //same stuff but detailed :
    
    // {
    //     get
    //     {
    //         return _collectedCoins.Count; //can be seen by everybody but not changed
    //     }
    // }

    public int NbCoinsReamining => _coins.Count;
    
    private List<Coins> _coins; //COI -> coins class
    private List<Coins> _collectedCoins; 
    
    void Start()
    {
        _coins = GetComponentsInChildren<Coins>().ToList();
        _collectedCoins = new List<Coins>();
        
        activate_coins();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.SetActive(true);
    }

    private void activate_coins()
    {
        foreach (Coins c in _coins)
        {
            c.gameObject.SetActive(true);
            c._coinManager = this;
        }
    }

    public void Collect(Coins c)
    {
        _coins.Remove(c);
        c.gameObject.SetActive(false);
        _collectedCoins.Add(c);
    }
}
