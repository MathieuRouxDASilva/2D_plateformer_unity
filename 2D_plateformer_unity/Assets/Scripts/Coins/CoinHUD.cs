using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;
using UnityEngine.Serialization;

public class CoinHUD : MonoBehaviour
{
    //private Text text;
    public static int CoinAmount = 0;
    private TextMeshProUGUI _text;

    private void Start ()
    {
        _text = GetComponent<TextMeshProUGUI>(); 
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = CoinAmount.ToString();
    }
}
