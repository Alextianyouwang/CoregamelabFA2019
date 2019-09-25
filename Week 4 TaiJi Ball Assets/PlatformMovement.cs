using UnityEngine;
using UnityEngine.UI;

public class PlatformMovement : MonoBehaviour
{

    Rigidbody2D rb;
    public GameObject LeftPlayer;
    public GameObject Bullet;
    public GameObject LeftPointerHodder;


    public GameObject LeftPointer;
    Vector2 direction;

    float forceAmount;

    public GameObject LeftForceIndicator;
    public GameObject BulletStart;

    public Text LeftPlayerBulletAmount;


    public float timer;

    // Start is called before the first frame update
    void Start()
    {
       // LeftForceIndicator.transform.position = new Vector2(-3, -4);
      
        rb = GetComponent<Rigidbody2D>();
        forceAmount = 10;
        // rotationVector = 1;

        // PointerHodder.transform.rotation = Quaternion.Euler(0, 0, RotationZ);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.localScale = new Vector2(7 - timer/30 , 10.0f);
        LeftPointerHodder.transform.position = LeftPlayer.transform.position;
        LeftPointerHodder.transform.Rotate(new Vector3(0, 0, -0.5f));

        LeftForceIndicator.transform.localScale = new Vector2(forceAmount / 5, 3.0f);

        LeftPointer.transform.localScale = new Vector2(0.60f - forceAmount / 90, 0.21f + forceAmount / 80);

        var speed = 30f;
        var intensity = (forceAmount - 15) / 80;

        LeftForceIndicator.transform.position = new Vector2(
         intensity * Mathf.PerlinNoise(speed * Time.time, 1) - 3.5f,
         intensity * Mathf.PerlinNoise(speed * Time.time, 2) - 4);
        //  if (RotationZ >= 20)
        {
            //    rotationVector = -rotationVector;
        }


       
         var countBullet = GameObject.FindGameObjectsWithTag("LeftBullet").Length;
        LeftPlayerBulletAmount.text = (2-countBullet).ToString();
        if (countBullet < 2 && Input.GetKeyDown(KeyCode.W))
        {
            inst(direction);
        }

       

        transform.position = new Vector2(-3.5f, -2);

        if (Input.GetKey(KeyCode.A))
        {
            //transform.rotation = Quaternion.Euler(0, 0, x);
            // transform.Rotate(new Vector3(0, 0, rotateSpeed++));

            transform.Rotate(new Vector3(0, 0, 1));

        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.rotation = Quaternion.Euler(0, 0, x);
            // transform.Rotate(new Vector3(0, 0, rotateSpeed++));

            transform.Rotate(new Vector3(0, 0, -1));
        }

        Vector2 difference = LeftPointer.transform.position - LeftPlayer.transform.position;
        float distance = difference.magnitude;
        direction = difference / distance;

       // Vector2 BulletTraveldistance = Bullet.transform.position - LeftPlayer.transform.position;
      //  float traveldistance = BulletTraveldistance.magnitude;
       // Bullet.GetComponent<Rigidbody2D>().mass = 5 - traveldistance;



    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.S))

        {

            //forceAmount = Mathf.Sin(0.3f * Time.time) * 20f;
            forceAmount += 0.2f;

            if (forceAmount >= 45)
            {
                forceAmount = 45;
            }

        }
        else
        {
            forceAmount -= 0.05f;
            if (forceAmount <= 10)
            {
                forceAmount = 10;
            }
        };

        LeftForceIndicator.GetComponent<SpriteRenderer>().color = new Color(forceAmount/70-0.4f,1-(forceAmount/35), 1.3f - (forceAmount / 35));
    }

    void inst(Vector2 direction)
    {
        GameObject B = Instantiate(Bullet) as GameObject;
        B.transform.position = BulletStart.transform.position;
        B.GetComponent<Rigidbody2D>().AddForce(direction * forceAmount, ForceMode2D.Impulse);
        B.transform.localScale = new Vector2(0.65f - forceAmount / 110, 0.65f - forceAmount / 110);

    }
}