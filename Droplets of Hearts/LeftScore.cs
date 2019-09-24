using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LeftScore : MonoBehaviour
{
    public GameObject RightPlayer;
    public Text LeftPlayerScore;
    public float Score = 0;

    public GameObject LeftWinScreen;


    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        LeftPlayerScore.text = Score.ToString();
        if (Score >= 7)

        {
            //LeftWinScreen.transform.position = new Vector2(-3.86f, 13.6f);
            LeftWinScreen.transform.Translate(new Vector2(0, -0.3f));
            if (LeftWinScreen.transform.position.y <= 1.14f)
            {
                LeftWinScreen.transform.position = new Vector2(-3.86f, 1.14f);
               // Time.timeScale = 0;

            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RightPlayer")
        {
            AddScore();
            RightPlayer.transform.position = new Vector2(Random.Range(2.0f, 4.0f), 2);
            RightPlayer.GetComponent<Rigidbody2D>().Sleep();

           

        }
    }

    void AddScore()
    {
        Score++;
    }
}
