using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUTTONGONE : MonoBehaviour
{

    public GameObject hs1;
    public GameObject hs2;
    public GameObject hs3;
    public GameObject hs4;
    public GameObject hs5;
   

    // Start is called before the first frame update
    void Start()
    {
        Lv2();
        Lv3();
        Lv4();
        Lv5();
        Lv6();
       
        PlayerPrefs.GetInt("lv2", 0);
        PlayerPrefs.GetInt("lv3", 0);
        PlayerPrefs.GetInt("lv4", 0);
        PlayerPrefs.GetInt("lv5", 0);
        PlayerPrefs.GetInt("lv6", 0);
       




    }

    void Lv2()
    {
        hs1.gameObject.SetActive(PlayerPrefs.GetInt("lv2") == 0);

    }

    void Lv3()
    {
        hs2.gameObject.SetActive(PlayerPrefs.GetInt("lv3") == 0);
    }


    void Lv4()
    {
        hs3.gameObject.SetActive(PlayerPrefs.GetInt("lv4") == 0);
    }

    void Lv5()
    {
        hs4.gameObject.SetActive(PlayerPrefs.GetInt("lv5") == 0);
    }

    void Lv6()
    {
        hs5.gameObject.SetActive(PlayerPrefs.GetInt("lv6") == 0);

    }

    

    public void Lv1Click()
    {
        if (PlayerPrefs.GetInt("highscore", 0) >= 500)
        {
            PlayerPrefs.SetInt("lv2", 2);
            PlayerPrefs.Save();
            Lv2();
            Lv3();
            Lv4();
            Lv5();
            Lv6();
        }



    }

    public void Lv2Click()
    {
        if (PlayerPrefs.GetInt("highscore", 0) >= 1000)
        {
            PlayerPrefs.SetInt("lv3", 3);
            PlayerPrefs.Save();
            Lv2();
            Lv3();
            Lv4();
            Lv5();
            Lv6();
        }
       
    }

    public void Lv3Click()
    {
        if (PlayerPrefs.GetInt("highscore", 0) >= 1500)
        {
            PlayerPrefs.SetInt("lv4", 4);
            PlayerPrefs.Save();
            Lv2();
            Lv3();
            Lv4();
            Lv5();
            Lv6();
        }
       

    }

    public void Lv4Click()
    {
        if (PlayerPrefs.GetInt("highscore", 0) >= 3000)
        {
            PlayerPrefs.SetInt("lv5", 5);
            PlayerPrefs.Save();
            Lv2();
            Lv3();
            Lv4();
            Lv5();
            Lv6();
        }

    }

    public void Lv5Click()
    {
        if (PlayerPrefs.GetInt("highscore", 0) >= 25000)
        {
            PlayerPrefs.SetInt("lv6", 6);
            PlayerPrefs.Save();
            Lv2();
            Lv3();
            Lv4();
            Lv5();
            Lv6();
        }
        

    }

    
}