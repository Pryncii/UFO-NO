using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
   
    public GameObject Effectss;
    public GameObject effect;

    public float speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        Instantiate(Effectss, transform.position, Quaternion.identity);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Pickup(other);

        }
        void Pickup(Collider2D Player)
        {

            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);

            Movement bullet = Player.GetComponent<Movement>();

            
            

                bullet.score += 200;

            

        }
    }
}
