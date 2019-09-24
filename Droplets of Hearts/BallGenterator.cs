using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenterator : MonoBehaviour
{   public GameObject ball;
   
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //ball.transform.position = new Vector2(Random.Range(-5, 5), 5);
    }

   

 
}
