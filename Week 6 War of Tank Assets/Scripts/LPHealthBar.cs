using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LPHealthBar : MonoBehaviour
{
    Image HealthBar;
    float maxHealth = 100.0f;
    public static float P1health;
    // Start is called before the first frame update
    void Start()
    {
        HealthBar = GetComponent<Image>();
        P1health = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = P1health / maxHealth;

        if (P1health <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
