using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wrapping : MonoBehaviour
{
    float x = 8.0f;
    Rigidbody2D rb;



   // public Text ScoreLeft;
    //public Text ScoreRight;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= x)
        {
            transform.position = new Vector2(-x, transform.position.y);

        }
        else if (transform.position.x <= -x)
        {
            transform.position = new Vector2(x, transform.position.y);
        }

      //  ScoreLeft.text = LeftScore.ToString();
      //  ScoreRight.text = RightScore.ToString();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Destroy(this.gameObject);
       // Destroy(this.gameObject.FindWithTag("RightBullet"));

        //Destroy(GameObject.FindWithTag("LeftPlayer"));

        // Destroy(GameObject.FindWithTag("RightPlayer"));

        //GameObject L = Instantiate(leftPlayer) as GameObject;
        // L.transform.position = new Vector2(0, 0);

    }

    //  void LeftAddScore()
    // {
    //var countplayerLeft = GameObject.FindGameObjectsWithTag("LeftPlayer").Length;
    // if (countplayerLeft < 1)
    //{
    //  RightScore++;

    //  GameObject l = Instantiate(leftPlayer) as GameObject;
    //  l.transform.position = new Vector2(-4, 0);

}

      //  var countplayerRight = GameObject.FindGameObjectsWithTag("RightPlayer").Length;
       // if (countplayerRight < 1)
      //  {
       //     LeftScore++;

      //  }
  //  }

//}
