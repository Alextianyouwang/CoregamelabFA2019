using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class platform2Movement : MonoBehaviour
{

    Rigidbody2D rb;
    public GameObject RightPlayer;
    public GameObject Bullet;
    public GameObject RightPointerHodder;

  
    public GameObject RightPointer;
    Vector2 direction;

    float forceAmount;

    public GameObject RightForceIndicator;
    public GameObject BulletStart;

    public Text RightPlayerBulletAmount;

    public float timer;

    

   // public GameObject LeftBoundry;




    // Start is called before the first frame update
    void Start()
    {
        
        RightForceIndicator.transform.position = new Vector2(4, -4);
        
        rb = GetComponent<Rigidbody2D>();
        forceAmount = 10;
       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        transform.localScale = new Vector2(7 - timer/30, 10.0f);

        RightPointerHodder.transform.position = RightPlayer.transform.position;
        RightPointerHodder.transform.Rotate(new Vector3(0, 0, 0.5f));

        RightForceIndicator.transform.localScale = new Vector2(forceAmount / 5, 3.0f);

        RightPointer.transform.localScale = new Vector2(0.60f - forceAmount / 90, 0.21f + forceAmount / 80);
        var speed = 30f;
        var intensity = (forceAmount-15)/80;

        RightForceIndicator.transform.position =  new Vector2(
         intensity*Mathf.PerlinNoise(speed * Time.time, 1)+3.5f,
         intensity*Mathf.PerlinNoise(speed * Time.time, 2)-4 ) ;
       
        var countBullet = GameObject.FindGameObjectsWithTag("RightBullet").Length;
        RightPlayerBulletAmount.text = (2 - countBullet).ToString();
        if (countBullet < 2 && Input.GetKeyDown(KeyCode.UpArrow))
        {
            inst(direction);
        }


        transform.position = new Vector2(3.5f, -2);
       
        if (Input.GetKey(KeyCode.LeftArrow))
        {
          

            transform.Rotate(new Vector3(0, 0, 1));

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
           

            transform.Rotate(new Vector3(0, 0, -1));
        }

        Vector2 difference = RightPointer.transform.position - RightPlayer.transform.position;
        float distance = difference.magnitude;
        direction = difference / distance;

       


        
       

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow))

        {

         
            forceAmount += 0.2f;

            if (forceAmount >= 45)
            {
                forceAmount = 45;
            }

        }
        else
        { forceAmount -= 0.05f;
            if (forceAmount <= 10)
            {
                forceAmount = 10;
            } 
        };
        RightForceIndicator.GetComponent<SpriteRenderer>().color = new Color(forceAmount / 70 - 0.4f, 1 - (forceAmount / 35), 1.3f - (forceAmount / 35));


    }


    void inst(Vector2 direction)
    {
        GameObject B = Instantiate(Bullet) as GameObject;
        B.transform.position = BulletStart.transform.position;
        B.GetComponent<Rigidbody2D>().AddForce(direction*forceAmount, ForceMode2D.Impulse);
        B.transform.localScale = new Vector2(0.65f-forceAmount / 110, 0.65f-forceAmount / 110);
    }

   
}
