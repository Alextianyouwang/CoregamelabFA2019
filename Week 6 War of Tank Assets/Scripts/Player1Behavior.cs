using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Behavior : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    Rigidbody2D rb;
    public GameObject BarralHodder;

    float width = Screen.width;
    float height = Screen.height;
    float timer;

    public GameObject BulletStart;

    Vector2 direction;

    public GameObject bullet;

    public GameObject Rocket;

    bool canMachineGun;
    bool canRocket;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        xSpeed = Random.Range(2.0f, 2.5f) ;
        ySpeed = Random.Range(2.0f, 2.5f);

        canMachineGun = false;
        canRocket = false;

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (canRocket)
        {
            if (timer >= 3)
            {
                GameObject r = Instantiate(Rocket) as GameObject;
                timer = 0;

            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            BarralHodder.transform.Rotate(new Vector3(0, 0,-2));
        }

        if (Input.GetKey(KeyCode.A))
        {
            BarralHodder.transform.Rotate(new Vector3(0, 0, 2));
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            ySpeed = -ySpeed;
       
        }
        if (!canMachineGun)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Vector2 difference = BulletStart.transform.position - transform.position;
                float distance = difference.magnitude;
                direction = difference / distance;

                inst(direction);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.S))
            {


                Vector2 difference = BulletStart.transform.position - transform.position;
                float distance = difference.magnitude;
                direction = difference / distance;
                if (timer >= 0.03f)
                {
                    inst(direction);
                    timer = 0;

                }
            }
        }
       
    }

    private void FixedUpdate()
    {

        transform.Translate(new Vector2(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime));

       
        
    }

    void inst(Vector2 direction)
    {
        GameObject b = Instantiate(bullet) as GameObject;
        b.transform.rotation = BarralHodder.transform.rotation;
        b.transform.position = BulletStart.transform.position;
        b.GetComponent<Rigidbody2D>().velocity=(direction * 20);
        Debug.Log("Fire");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.tag == "PlayZone")
        {
       
       
            xSpeed = -xSpeed;
        }

        if (collision.gameObject.tag == "PlayZoneY")
        {
           
            ySpeed = -ySpeed;
   
        }

        if (collision.gameObject.tag == "Player2")
        {
            ySpeed = -ySpeed;
            xSpeed = -xSpeed;

        }
        if (collision.gameObject.tag == "P2Bullet")
        {
            LPHealthBar.P1health -= 4;
            Debug.Log("LP-10");
        }
        if (collision.gameObject.tag == "P2RKT")
        {
            LPHealthBar.P1health -= 80;
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "MB")
        {
            canMachineGun = true;
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "RB")
        {
            canRocket = true;
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player2")
        {
            ySpeed = -ySpeed;
            xSpeed = -xSpeed;

        }
    }
}
