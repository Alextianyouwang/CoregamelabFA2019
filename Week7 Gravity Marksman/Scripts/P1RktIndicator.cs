using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1RktIndicator : MonoBehaviour
{
    Image P1RktInd;
    public static float energy;
    float maxEnergy = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        P1RktInd = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        P1RktInd.fillAmount = energy / maxEnergy;
             
    }
}
