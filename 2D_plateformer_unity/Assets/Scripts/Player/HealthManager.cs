using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using Vector2 = System.Numerics.Vector2;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;
    public int nbOfTries = 3;
    public GameObject losePanel;
    public Player player;


    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            nbOfTries--;
        }

        if (nbOfTries > 0 && healthAmount <= 0)
        {
            //Application.LoadLevel(Application.loadedLevel);
            healthAmount = 100;
            healthBar.fillAmount = healthAmount / 100f;


            player.transform.position = new Vector3(-14, 13, -9.8f);
        }
        else if (nbOfTries <= 0 && healthAmount <= 0)
        {
            losePanel.gameObject.SetActive(true);
            player.transform.position = new Vector3(0, 0, 0);
        }
    }

    public void Damage(float dmg)
    {
        healthAmount -= dmg;
        healthBar.fillAmount = healthAmount / 100f;
    }
}