using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2RktIndicator : MonoBehaviour
{
    Image P2RktInd;
    public static float energy;
    float maxEnergy = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        P2RktInd = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        P2RktInd.fillAmount = energy / maxEnergy;

    }
}