using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSys : MonoBehaviour
{
    public GameObject ball;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        inst();
    }

    // Here I do not know why the On-trigger collider is destroied together with the ball, the collider should always be there!


    void inst()

    {
        GameObject b = Instantiate(ball) as GameObject;
        b.transform.position = new Vector2(Random.Range(-5,5), 5);

    }
}
