using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOBILECONT : MonoBehaviour
{
    public Movement player;
    public Missile missile;
    public Sneakers sneak;

    public void moveup()
    {
        if (player.transform.position.y < player.maheight && gameObject.activeSelf == true)
        {
            player.targetPos = new Vector2(player.transform.position.x, player.transform.position.y + player.Yin);
            player.transform.position = player.targetPos;
            player.GetComponent<AudioSource>().Play();
        }
    }

    public void movedown()
    {
        if (player.transform.position.y > player.miheight && gameObject.activeSelf == true)
        {
            player.targetPos = new Vector2(player.transform.position.x, player.transform.position.y - player.Yin);
            player.transform.position = player.targetPos;
            player.GetComponent<AudioSource>().Play();
        }
    }

    
    

    public void lazer()
    {
        if (player.rkp < player.apa && gameObject.activeSelf == true)
        {
            player.Gun.SetTrigger("Gun");
            Instantiate(player.Laser, player.shotPoint.position, Quaternion.Euler(0, 0, -90));
            player.rkp++;
            player.laz--;
        }

        if (player.rkp > player.apa && gameObject.activeSelf == true)
        {
            return;
        }
    }

    public void teleup()
    {
        if (player.transform.position.y < player.maxheight && gameObject.activeSelf == true)
        {
            player.targetPos = new Vector2(player.transform.position.x, player.transform.position.y + player.Yincrement);
            player.transform.position = player.targetPos;
            player.GetComponent<AudioSource>().Play();
            player.Boom = (GameObject)Instantiate(player.Boom, player.transform.position, player.transform.rotation);
            Instantiate(player.effect, player.transform.position, Quaternion.identity);
        }
    }

    public void teledown()
    {
        if (player.transform.position.y > player.minheight && gameObject.activeSelf == true)
        {
            player.targetPos = new Vector2(player.transform.position.x, player.transform.position.y - player.Yincrement);
            player.transform.position = player.targetPos;
            player.GetComponent<AudioSource>().Play();
            player.Boom = (GameObject)Instantiate(player.Boom, player.transform.position, player.transform.rotation);
            Instantiate(player.effect, player.transform.position, Quaternion.identity);
        }
    }

    public void teledash()
    {
        player.Boom = (GameObject)Instantiate(player.Boom, player.transform.position, player.transform.rotation);
        Instantiate(player.effectss, player.transform.position, Quaternion.identity);
    }


}
