using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed;
    public int health = 1;
    public GameObject effect;
    public int shophealth;
    public int healty;
    public int hol = 1;

    // Start is called before the first frame update
    void Start()
    {
       health = PlayerPrefs.GetInt("laze", 1);
        
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        

        if (health <= 0)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void PIERCE()
    {
       

        if (PlayerPrefs.GetInt("barya", 0) >= 100 && PlayerPrefs.GetInt("laze", 1) <= 1)
        {

            PlayerPrefs.SetInt("laze", 2);
            PlayerPrefs.Save();
            int val = PlayerPrefs.GetInt("barya", 0);
            val -= 100;
            PlayerPrefs.SetInt("barya", val);
        }
    }
}
