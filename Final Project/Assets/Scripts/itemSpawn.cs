using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawn : MonoBehaviour
{
    public float targetTime = 10.0f;
    float storedTime;
    public GameObject trash;
    public GameObject treasure;
    System.Random rand = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        storedTime = targetTime;
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        if(targetTime <= 0.0f)
        {
            timerEnded();
        }
    }
    void timerEnded()
    {
        rand = new System.Random();
        int spawnDecision = rand.Next(0, 2);
        if(spawnDecision == 0)
        {
            targetTime = storedTime;
            Instantiate(trash, new Vector3(rand.Next(-9, 9), 5.7f, 0), Quaternion.identity);
        }
        if (spawnDecision == 1)
        {
            targetTime = storedTime;
            Instantiate(treasure, new Vector3(rand.Next(-9, 9), 5.7f, 0), Quaternion.identity);
        }
    }
}
