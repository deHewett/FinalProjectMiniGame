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
    int spawnCount = 0;

    

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
        if(spawnCount >= 5)
        {
            spawnCount = 0;
            storedTime -= 0.2f;
            if (storedTime <= 1)
            {
                storedTime = 1;
            }
        }
    }
    void timerEnded()
    {
        rand = new System.Random();
        int spawnDecision = rand.Next(0, 2);
        spawnCount++;
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
