using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Missile : MonoBehaviour
{
    public Vector2 targetPos;
    public float Xincrement = 4;
    public float maxlength;
    public float minlength;
    public float speed;
    public GameObject Boom;
    public int damage = 1;
    public bool cooldown = false;
    public float Stap;
    public GameObject Miss;
    public GameObject effect;
    public Animator camAnim;
    public int rkp = 0;
    public int apa = 5;
    public int score;
    public Movement player;
    public Laser laz;
    public int health;


    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        health = PlayerPrefs.GetInt("laze", laz.health += laz.shophealth);
        Miss = FindObjectOfType<Missile>().gameObject;
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            camAnim.SetTrigger("Shakes");
            other.GetComponent<Movement>().health -= damage;
            Debug.Log(other.GetComponent<Movement>().health);
            Boom = (GameObject)Instantiate(Boom, transform.position, transform.rotation);
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (other.CompareTag("Laser"))
        {
            other.GetComponent<Laser>().health -= damage;
            Boom = (GameObject)Instantiate(Boom, transform.position, transform.rotation);
            Instantiate(effect, transform.position, Quaternion.identity);
           
            Destroy(gameObject);
            
            
            
            



        }

        if (other.CompareTag("Despawn"))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("Explosion"))
        {
            Boom = (GameObject)Instantiate(Boom, transform.position, transform.rotation);
            Destroy(gameObject);
        }


    }


    void Update()
    {
        

        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.RightArrow) && cooldown == false)
        {
            targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
            transform.position = targetPos;
            Invoke("ResetCooldown", Stap);
            cooldown = true;
            GetComponent<AudioSource>().Play();

        }

       

    }



    void ResetCooldown()
    {
        cooldown = false;
    }

    

}
