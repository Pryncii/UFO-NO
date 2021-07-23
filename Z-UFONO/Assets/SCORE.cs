using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORE : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float sss;
    

 
    // Start is called before the first frame update
    void Start()
    {
        scoreAmount =0f;
        sss =1f;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        scoreText.text = (int)scoreAmount + "";
        scoreAmount +=sss * Time.deltaTime;
    }
}
