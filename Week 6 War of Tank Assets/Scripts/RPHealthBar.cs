using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RPHealthBar : MonoBehaviour
{
    Image HealthBar;
    float maxHealth = 100.0f;
    public static float P2health;
    // Start is called before the first frame update
    void Start()
    {
        HealthBar = GetComponent<Image>();
        P2health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = P2health / maxHealth;
        if (P2health <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

   
}
