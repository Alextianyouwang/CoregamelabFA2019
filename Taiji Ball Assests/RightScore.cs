using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightScore : MonoBehaviour
{
   
    public Text RightPlayerScore;
    public float Score = 0;

    public GameObject LeftPlayer;

    public GameObject RightWinScreen;

  

    // Start is called before the first frame update
    void Start()
    {
 

    }

    // Update is called once per frame
    void Update()
    {
        RightPlayerScore.text = Score.ToString();

        if (Score >= 7)

        {
            //LeftWinScreen.transform.position = new Vector2(-3.86f, 13.6f);
            RightWinScreen.transform.Translate(new Vector2(0, -0.3f));
            if (RightWinScreen.transform.position.y <= 1.14f)
            {
                RightWinScreen.transform.position = new Vector2(3.86f, 1.14f);
                //Time.timeScale = 0;
            }

        }
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LeftPlayer")
        { AddScore();

            LeftPlayer.transform.position = new Vector2(Random.Range(-2.0f,-4.0f), 2);
            LeftPlayer.GetComponent<Rigidbody2D>().Sleep();
            
        }
    }
    void AddScore()

    {
        Score++;
    }
}
