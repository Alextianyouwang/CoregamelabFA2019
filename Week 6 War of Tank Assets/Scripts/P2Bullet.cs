using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 8 || transform.position.x <= -8)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.y >= 8 || transform.position.y <= -8)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player1")
        {
            Destroy(this.gameObject);
        }
    }
}
