using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLevel : MonoBehaviour
{
   

    Text showLevel;

    public static float newLevel;

    // Start is called before the first frame update
    void Start()
    {
        showLevel = GetComponent<Text>();
      
    }

    // Update is called once per frame
    void Update()
    {
       

       
    }       


   public void changeLevel(float newLevel)
    {


        showLevel.text = Mathf.RoundToInt(newLevel).ToString();
    }
}
