using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trans : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            transform.localScale = new Vector2(1f, 0.7f);
            
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.localScale = new Vector2(1f, 1f);
        }
    }
}
