using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float timer;

 
    int  xspeed = 1;
    int  yspeed = 1;
    public GameObject circle;
    float posx;
    float posy;
    public float freq;
    public float amp;

    public GameObject background;
    public float width;
    public float height;



    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(transform.position);
        transform.position = new Vector2(Random.Range(-400, 400), Random.Range(-300,300));
        transform.localScale = new Vector2(80, 60);

        speed = 300;
        freq = 3;
        amp = 300;
   
        timer = 0;

        width = 800;
        height = 600;

        background.transform.position = new Vector2(0,0);
        background.transform.localScale = new Vector2(width, height);

        circle.transform.position = new Vector2(0, 0);
        circle.transform.localScale = new Vector2(60, 60);
    }

    // Update is called once per frame
    void Update()
    {
        

        transform.Translate(new Vector2(xspeed, yspeed)*Time.deltaTime*speed);


        if (transform.position.x >= width/2-40)
        {
            xspeed = -xspeed;

            transform.position = new Vector2(width / 2 - 40, transform.position.y);

            // width = Random.Range(700, 900);
            //height = Random.Range(500, 700);
            //background.transform.localScale = new Vector2(width,height);

            width = Mathf.Sin(Time.time/2) * amp+380;
           // height = Mathf.Cos(Time.time) * amp;
            background.transform.localScale = new Vector2(width, height);

        }

        else if (transform.position.x <= -(width / 2 - 40))
        {
            xspeed = -xspeed;

            transform.position = new Vector2(-(width / 2 - 40), transform.position.y);

            //width = Random.Range(700, 900);
            //height = Random.Range(500, 700);
            //background.transform.localScale = new Vector2(width, height);

            width = Mathf.Sin(Time.time/2) * amp + 380;
            //height = Mathf.Cos(Time.time) * amp;
            background.transform.localScale = new Vector2(width, height);

        }

        if (transform.position.y >= height/2-30)
        {
            yspeed = -yspeed;

            transform.position = new Vector2(transform.position.x, height / 2 - 30);

            //width = Random.Range(700, 900);
            //height = Random.Range(500, 700);
            // background.transform.localScale = new Vector2(width, height);
            // width = Mathf.Sin(Time.time) * amp + 400;

            height = Mathf.Cos(Time.time/2) * amp + 360;
            background.transform.localScale = new Vector2(width, height);

        }

        else if (transform.position.y <= -(height / 2 - 30))
        {
            yspeed = -yspeed;
            transform.position = new Vector2(transform.position.x,-(height / 2 - 30));

            //width = Random.Range(700, 900);
            // height = Random.Range(500, 700);
            //background.transform.localScale = new Vector2(width, height);
            //width = Mathf.Sin(Time.time) * amp + 400;

            height = Mathf.Cos(Time.time/2) * amp + 360;
            background.transform.localScale = new Vector2(width, height);

        }



        circle.transform.localScale = new Vector2(Mathf.Sin(Time.time)*amp,Mathf.Cos(Time.time)*amp);

  
        posx = Mathf.Sin(Time.time * freq) * 400;
        posy = Mathf.Cos(Time.time * freq) * 400;

        circle.transform.position = new Vector2(posx + transform.position.x, posy + transform.position.y);
        circle.transform.localScale = new Vector2(height/2 , width/2
            );
        
       // if (timer >= 1)

        {
            //transform.position= new Vector2(Random.Range(-400, 400), Random.Range(-300, 300));


           // timer = 0;

        };


        //timer += Time.deltaTime;

    }

}
