using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "missile")
        { HealthBar.health -= 4;
           
        }
        GameObject E = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(E, 1.0f);
        Destroy(this.gameObject);
    }
}
