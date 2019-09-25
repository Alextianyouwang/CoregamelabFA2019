using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnning : MonoBehaviour
{

    public GameObject Climber1;
    public float amp;
    public float freq;
    float posx;
    float posy;
    
 


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0, 0);
        freq = 3;
        amp = 5;

    }

    // Update is called once per frame
    void Update()
    {
        posx = Mathf.Sin(Time.time * freq) * amp;
        posy = Mathf.Cos(Time.time * freq) * amp;
        Climber1.transform.position = new Vector2(posx + transform.position.x, posy + transform.position.y);

    }
}
