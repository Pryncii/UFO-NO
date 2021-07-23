using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INVIS : MonoBehaviour
{
    public GameObject Effectsss;
    public GameObject effect;
    public int shopduration;
    public float speed;
    public int duration;
    public int dudu;
    

    void Start()
    {
        
        duration = PlayerPrefs.GetInt("length", 10);
        PlayerPrefs.Save();
    }
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Movement bullet = other.GetComponent<Movement>();
            
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<BoxCollider2D>().enabled = false;
            other.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            StartCoroutine (Pickup(other));
            bullet.score += 50;
           

        }
        IEnumerator Pickup (Collider2D Player)
        {
            yield return new WaitForSeconds(duration);
            Player.GetComponent<BoxCollider2D>().enabled = true;
            other.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            Effectsss.SetActive(true);




        }

    }

    public void INVISI()
    {
        if (PlayerPrefs.GetInt("barya", 0) >= 100 && PlayerPrefs.GetInt("length", 10) <= 10)
        {


            PlayerPrefs.SetInt("length", 20);
            PlayerPrefs.Save();
            int val = PlayerPrefs.GetInt("barya", 0);
            val -= 100;
            PlayerPrefs.SetInt("barya", val);
        }
    }
}
