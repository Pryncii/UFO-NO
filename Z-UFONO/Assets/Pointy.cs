using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointy : MonoBehaviour
{
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstacle, transform.position, Quaternion.Euler(0, 180, 0));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
