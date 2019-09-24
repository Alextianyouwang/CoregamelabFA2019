using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject ball;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("inst", 1f, Random.Range(1.5f, 2));
        float spinForce;
        spinForce = Random.Range(-200, 200);
        rb.AddTorque(spinForce);
    }

    // Update is called once per frame
    void Update()
    {
    
       
        ball.transform.position = new Vector2(Random.Range(-5, 5), 5);
       
    }
    void inst()

    {
        
        
        Instantiate(ball, ball.transform.position, transform.rotation);
       
    }
}
