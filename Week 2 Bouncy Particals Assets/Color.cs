using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        collision.gameObject.GetComponent<SpriteRenderer>().color = Random.ColorHSV(1.0f,0.0f,1.0f,1.0f,1.0f,0.0f);
    }
}
