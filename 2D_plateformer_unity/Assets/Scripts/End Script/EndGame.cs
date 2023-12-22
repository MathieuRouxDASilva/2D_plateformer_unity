using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class EndGame : MonoBehaviour
{
    public GameObject winPanel;
    public Player player;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = new Vector3(0, 0, 0);
            winPanel.gameObject.SetActive(true);
        }
    }
}
