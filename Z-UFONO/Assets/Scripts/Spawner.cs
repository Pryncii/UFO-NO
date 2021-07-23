using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;
    public float timebs;
    public float stimebs;
    public float decreaseTime;
    public float minTime = 1f;

    private void Update()
    {
        if (timebs <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timebs = stimebs;
            if (stimebs > minTime)
            stimebs -= decreaseTime;

        }
        else
        {
            timebs -= Time.deltaTime;
        }
    }


}
