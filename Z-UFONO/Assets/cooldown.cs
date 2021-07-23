using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cooldowns : MonoBehaviour
{
    private bool cooldown = false;
    public float Stap = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cooldown == false)
        {
            Invoke("ResetCooldown", Stap);
            cooldown = true;
            
        }
    }

    void ResetCooldown()
    {
        cooldown = false;
    }
}
