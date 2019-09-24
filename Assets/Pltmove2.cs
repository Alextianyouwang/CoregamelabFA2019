using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pltmove2 : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Platform, transform.position, transform.rotation);
        transform.position = new Vector2(0, 1);

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.mousePosition.x;
        transform.position = new Vector2(0, 0);
        transform.rotation = Quaternion.Euler(0, 0, (x - 300) / 10);
    }

}
