using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poweruplaser : MonoBehaviour
{
    public int rkp = 5;
    public int apa = 5;
    public GameObject effect;
    public GameObject Laser;
    public Transform shotPoint;
    
    public GameObject Boom;
    public GameObject Effectss;

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

            if (bullet.rkp >= 5)
            {
                
                bullet.rkp -= 5;
                bullet.laz += 5;
                
            }

            if (bullet.rkp == 4)
            {

                bullet.rkp -= 4;
                bullet.laz += 4;
            }

            if (bullet.rkp == 3)
            {

                bullet.rkp -= 3;
                bullet.laz += 3;
            }

            if (bullet.rkp == 2)
            {

                bullet.rkp -= 2;
                bullet.laz += 2;
            }

            if (bullet.rkp == 1)
            {

                bullet.rkp -= 1;
                bullet.laz += 1;
            }



        }
    }
}
