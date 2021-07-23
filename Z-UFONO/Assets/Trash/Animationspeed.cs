using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    
    public float speed;
    public float maxheight;
    public float minheight;
    public float maheight;
    public float miheight;
    public float Yin;
    public float maxlength;
    public float minlength;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxheight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minheight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown("w") && transform.position.y < maheight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yin);
            transform.position = targetPos;

        }

        else if (Input.GetKeyDown("s") && transform.position.y > miheight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yin);
            transform.position = targetPos;
        }


        


    }

}
