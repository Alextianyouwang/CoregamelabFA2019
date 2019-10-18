using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1Behavior : MonoBehaviour
{
    Rigidbody2D rb;


    public GameObject BH;

    public GameObject BS;

    public GameObject P1B;

    public GameObject P1Machine;

    public GameObject P1Rocket;

    public GameObject P1Bomb;



    public float forceAmount;

    bool canMachineGun = false;

    bool canRocket = false ;

    bool canBomb = false;

    float timer;
    
    // Start is called before the first frame update
    void Start()
    {

        P1RktIndicator.energy = 0;
       

        rb = GetComponent<Rigidbody2D>();

        forceAmount = 20;

        P1B.GetComponent<Rigidbody2D>().gravityScale = 1;
        P1Machine.GetComponent<Rigidbody2D>().gravityScale = 1;
        P1Rocket.GetComponent<Rigidbody2D>().gravityScale = 1;
        P1Bomb.GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    // Update is called once per frame
    void Update()

    {
      

        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.gravityScale = -rb.gravityScale;
            P1B.GetComponent<Rigidbody2D>().gravityScale = -P1B.GetComponent<Rigidbody2D>().gravityScale;
            P1Machine.GetComponent<Rigidbody2D>().gravityScale = -P1Machine.GetComponent<Rigidbody2D>().gravityScale;
            P1Rocket.GetComponent<Rigidbody2D>().gravityScale = -P1Rocket.GetComponent<Rigidbody2D>().gravityScale;
            P1Bomb.GetComponent<Rigidbody2D>().gravityScale = -P1Bomb.GetComponent<Rigidbody2D>().gravityScale;


        }

        if (Input.GetKey(KeyCode.A))
        {
            BH.transform.Rotate(new Vector3(0, 0, 1));
        }

        if (Input.GetKey(KeyCode.D))
        {
            BH.transform.Rotate(new Vector3(0, 0, -1));
        }

        if (!canBomb)
        {
            if (!canRocket)
            {
                if (!canMachineGun)
                {
                    if (Input.GetKeyDown(KeyCode.W))
                    {
                        Vector2 difference = BS.transform.position - transform.position;
                        float distance = difference.magnitude;
                        Vector2 direction = difference / distance;

                        rb.AddForce(-direction * 1.3f, ForceMode2D.Impulse);
                        inst(direction, forceAmount);

                    }
                }
                else
                {
                    if (Input.GetKey(KeyCode.W))
                    {
                        Vector2 difference = BS.transform.position - transform.position;
                        float distance = difference.magnitude;
                        Vector2 direction = difference / distance;

                        float force;
                        force = 0.09f;
                        rb.AddForce (-direction * force,ForceMode2D.Impulse) ;
                        if (timer >= 0.05f)
                        {
                            machineGun(direction, 25);
                            timer = 0;
                            
                        }

                    }
                }
            }
            else
            {
                P1RktIndicator.energy = timer;

                if (Input.GetKeyDown(KeyCode.W))
                {
                    if (timer >= 6)
                    {
                        timer = 6;
                    }
                    Vector2 difference = BS.transform.position - transform.position;
                    float distance = difference.magnitude;
                    Vector2 direction = difference / distance;


                    rb.AddForce(-direction * (5 + timer), ForceMode2D.Impulse);
                    rocket(direction);
                    timer = 0;


                }
            }
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.W))
            {

                Vector2 difference = BS.transform.position - transform.position;
                float distance = difference.magnitude;
                Vector2 direction = difference / distance;

                
                bomb(direction, 15);
                rb.AddForce(-direction * 5, ForceMode2D.Impulse);

            }
           
        }
       
       
        
    }

    void inst(Vector2 direction, float forceAmount )
    {
        GameObject b = Instantiate(P1B) as GameObject;
        b.transform.position = BS.transform.position;
        b.transform.rotation = BH.transform.rotation;
        b.GetComponent<Rigidbody2D>().velocity = direction * forceAmount;

   



    }

    void machineGun(Vector2 direction, float gunSpeed)
    {
        GameObject m = Instantiate(P1Machine) as GameObject;
        m.transform.position = BS.transform.position;
        m.transform.rotation = BH.transform.rotation;
        m.GetComponent<Rigidbody2D>().velocity = direction * gunSpeed;

    }

    void rocket(Vector2 direction)
    {
       

        GameObject r = Instantiate(P1Rocket) as GameObject;
      
        r.transform.position = BS.transform.position;
        r.transform.rotation = BH.transform.rotation;
        r.GetComponent<Rigidbody2D>().velocity = direction * (10+timer *3);

    }

   

    void bomb(Vector2 direction, float bombSpeed)
    {
        GameObject b = Instantiate(P1Bomb) as GameObject;
        b.transform.position = BS.transform.position;
        b.transform.rotation = BH.transform.rotation;
        b.GetComponent<Rigidbody2D>().velocity = direction * bombSpeed;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "hexagon")

        {
            canMachineGun = true;
            canRocket = false;
            canBomb = false;
            Destroy(collision.gameObject);
            timer = 0;
            P1RktIndicator.energy = 0;

        }

        if (collision.gameObject.tag == "triangle")

        {
           canRocket = true;
            canMachineGun = false;
            canBomb = false;
            Destroy(collision.gameObject);
            timer = 0;

        }

        if (collision.gameObject.tag == "P1dimond")

        {
            canBomb = true;
            canMachineGun = false;
            canRocket = false;
            Destroy(collision.gameObject);
            timer = 0;
            P1RktIndicator.energy = 0;


        }

        if (collision.gameObject.tag == "BE")
        {
            Vector2 difference = BombPos.bombPos - (Vector2)transform.position;
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;

            rb.AddForce(5 * -direction, ForceMode2D.Impulse);


            
        }



    }
}
