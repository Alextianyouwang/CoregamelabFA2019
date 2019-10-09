using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2A : MonoBehaviour
{
    Image indicator;
    public static float amo = 100;
    float maxAmo = 100;

    // Start is called before the first frame update
    void Start()
    {
        indicator = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        indicator.fillAmount = amo / maxAmo;
    }
}
