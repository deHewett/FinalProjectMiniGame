using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class itemSpawn : MonoBehaviour
{
    public float targetTime = 10.0f;
    float storedTime;
    public GameObject trash;
    public GameObject treasure;
    System.Random rand = new System.Random();
    int spawnCount = 0;
    public gameController gameController;
    public int spawnNumber = 1;
    bool roundOver;





    // Start is called before the first frame update
    void Start()
    {
        roundOver = false;
        spawnNumber =1;
        storedTime = targetTime;
        gameController = GameObject.Find("GameController").GetComponent<gameController>();
}

    // Update is called once per frame
    void Update()
    {
        if(gameController.lives <= 0 && SceneManager.GetActiveScene().name == "Level 1")
        {
            roundOver = true;
        }
        if (gameController.lives <= 0 && SceneManager.GetActiveScene().name == "Level 3")
        {
            roundOver = true;
        }
        if (gameController.timer < 0 && SceneManager.GetActiveScene().name == "Level 2")
        {
            roundOver = true;
        }
        else
        {
            targetTime -= Time.deltaTime;
            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
            if (spawnCount >= 5)
            {
                spawnCount = 0;
                storedTime -= 0.2f;
                if (storedTime <= 1)
                {
                    storedTime = 1;
                }
            }
        }

        
    }
    void timerEnded()
    {
        if (!roundOver)
        {
            if (SceneManager.GetActiveScene().name == "Level 3")
            {
                spawnNumber = 2;
            }
            for (int i = 0; i < spawnNumber; i++)
            {
                rand = new System.Random();
                int spawnDecision = rand.Next(0, 2);
                spawnCount++;
                if (spawnDecision == 0)
                {
                    rand = new System.Random();
                    targetTime = storedTime;
                    Instantiate(trash, new Vector3(rand.Next(-9, 9), 5.7f, 0), Quaternion.identity);
                }
                if (spawnDecision == 1)
                {
                    rand = new System.Random();
                    targetTime = storedTime;
                    Instantiate(treasure, new Vector3(rand.Next(-9, 9), 5.7f, 0), Quaternion.identity);
                }
            }
        }
        else
        {
            return;
        }
        
        
    }
}
