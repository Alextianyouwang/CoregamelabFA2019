using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class P2HP : MonoBehaviour
{
    Image P2Hb;
    public static float P2H = 100;
    float HealthMax = 100;

    // Start is called before the first frame update
    void Start()
    {
        P2Hb = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        P2Hb.fillAmount = P2H / HealthMax;

        if ( P2H <= 0)
        {
            SceneManager.LoadScene(1);
            P2H = 100;
            P1HP.P1H = 100;
            P1RktIndicator.energy = 0;
            P2RktIndicator.energy = 0;
        }

       
    }
}
