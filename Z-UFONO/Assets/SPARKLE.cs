using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SPARKLE : MonoBehaviour
{



    public Text coin;
   
    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
       

    }

    // Update is called once per frame
    void Update()
    {
        coin.text = PlayerPrefs.GetInt("barya", 0).ToString();
    }

    public void reset()
    {
        PlayerPrefs.DeleteAll();
        

    }
}
