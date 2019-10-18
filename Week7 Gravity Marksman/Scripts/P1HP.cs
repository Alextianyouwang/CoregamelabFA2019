using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class P1HP : MonoBehaviour
{
    Image P1Hb;
    public static float P1H = 100;
    float HealthMax = 100;

    // Start is called before the first frame update
    void Start()
    {
        P1Hb = GetComponent<Image>();
       
    }

    // Update is called once per frame
    void Update()
    {
        P1Hb.fillAmount = P1H / HealthMax;

        if (P1H <= 0)
        {
            SceneManager.LoadScene(2);
            P1H = 100;
            P2HP.P2H = 100;
            P1RktIndicator.energy = 0;
            P2RktIndicator.energy = 0;
        }
    }

    
}
