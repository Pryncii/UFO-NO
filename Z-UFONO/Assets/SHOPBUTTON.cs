using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHOPBUTTON : MonoBehaviour
{
   

    public GameObject ss1;
    public GameObject ss2;
    public GameObject ss3;
    public GameObject ss4;
    public GameObject ss5;


    // Start is called before the first frame update
    void Start()
    {
        SS1();
        SS2();
        SS3();
        SS4();
        SS5();

        PlayerPrefs.GetInt("sb1", 0);
        PlayerPrefs.GetInt("sb2", 0);
        PlayerPrefs.GetInt("sb3", 0);
        PlayerPrefs.GetInt("sb4", 0);
        PlayerPrefs.GetInt("sb5", 0);





    }

    void SS1()
    {
        ss1.gameObject.SetActive(PlayerPrefs.GetInt("sb1") == 0);

    }

    void SS2()
    {
        ss2.gameObject.SetActive(PlayerPrefs.GetInt("sb2") == 0);
    }


    void SS3()
    {
        ss3.gameObject.SetActive(PlayerPrefs.GetInt("sb3") == 0);
    }

    void SS4()
    {
        ss4.gameObject.SetActive(PlayerPrefs.GetInt("sb4") == 0);
    }

    void SS5()
    {
        ss5.gameObject.SetActive(PlayerPrefs.GetInt("sb5") == 0);

    }



    public void Lv1Click()
    {
        if (PlayerPrefs.GetInt("Health", 3) >= 50)
        {
            PlayerPrefs.SetInt("sb1", 0);
            PlayerPrefs.Save();
            SS1();
            SS2();
            SS3();
            SS4();
            SS5();
        }



    }

    public void Lv2Click()
    {
        if (PlayerPrefs.GetInt("barya", 0) >= 200)
        {
            PlayerPrefs.SetInt("sb2", 3);
            PlayerPrefs.Save();
            SS1();
            SS2();
            SS3();
            SS4();
            SS5();
        }

    }

    public void Lv3Click()
    {
        if (PlayerPrefs.GetInt("barya", 0) >= 100)
        {
            PlayerPrefs.SetInt("sb3", 4);
            PlayerPrefs.Save();
            SS1();
            SS2();
            SS3();
            SS4();
            SS5();
        }


    }

    public void Lv4Click()
    {
        if (PlayerPrefs.GetInt("barya", 0) >= 200)
        {
            PlayerPrefs.SetInt("sb4", 5);
            PlayerPrefs.Save();
            SS1();
            SS2();
            SS3();
            SS4();
            SS5();
        }

    }

    public void Lv5Click()
    {
        if (PlayerPrefs.GetInt("StapAgain", 10) == 3)
        { 
            PlayerPrefs.SetInt("sb5", 6);
            PlayerPrefs.Save();
            SS1();
            SS2();
            SS3();
            SS4();
            SS5();
        }


    }


}