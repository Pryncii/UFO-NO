using UnityEngine;

public class HOME : MonoBehaviour
{
    public GameObject Helps;
    public GameObject close;

    public void controls()
    {
        Helps.SetActive(true);
        close.SetActive(false);
    }



}

