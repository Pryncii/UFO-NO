using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SHOP : MonoBehaviour
{
    public Text coin;
    public Laser lazz;
    public Movement Player;
    public INVIS invisi;

    public void PIERCE()
    {
        coin.text = PlayerPrefs.GetInt("barya", 0).ToString();

        if (PlayerPrefs.GetInt("barya", 0) >= 300 && PlayerPrefs.GetInt("laze", 1) <= 1)
        {
            
            PlayerPrefs.SetInt("laze", 2);
            PlayerPrefs.Save();
            int val = PlayerPrefs.GetInt("barya", 0);
            val -= 300;
            PlayerPrefs.SetInt("barya", val);
        }
    }

    public void SCORE()
    {
        if (PlayerPrefs.GetInt("barya", 0) >= 200 && Player.shopscore <= 0)
        {
            
            PlayerPrefs.SetInt("skore", 500);
            PlayerPrefs.Save();
            int val = PlayerPrefs.GetInt("barya", 0);
            val -= 200;
            PlayerPrefs.SetInt("barya", val);
        }
    }

    public void INVISI()
    {
        if (PlayerPrefs.GetInt("barya", 0) >= 100 && invisi.shopduration <= 0)
        {

           
            PlayerPrefs.SetInt("length", invisi.duration += invisi.shopduration);
            PlayerPrefs.Save();
            int val = PlayerPrefs.GetInt("barya", 0);
            val -= 100;
            PlayerPrefs.SetInt("barya", val);
        }
    }
}
