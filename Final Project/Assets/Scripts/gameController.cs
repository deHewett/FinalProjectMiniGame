using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class gameController : MonoBehaviour
{
    public int score = 0;
    public int combo = 1;
    public int lives = 3;
    private int count = 0;
    float roundTime = 30f;
    public GameObject endScreen;
    public Text round1score;
    public Text round2score;
    public Text round3score;
    public Text final;
    public Text rewardText;
    public int timer;
    public GameObject timerText;
    public Text title;

    public int round1=0;
    public int round2=0;
    public int round3 = 0;
    public int finalScore=0;

    private string rewardS = "SMALL";
    private string rewardM = "MEDIUM";
    private string rewardL = "LARGE";

    // Start is called before the first frame update
    void Start()
    {
        roundTime = 30f;
        score = 0;
        
    }
    private void Awake()
    {
        roundTime = 30f;

        int numControllers = FindObjectsOfType<gameController>().Length;
        if (numControllers != 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    void OnEnable()
    {
        roundTime = 30f;
        SceneManager.sceneLoaded += onSceneLoaded;
    }
    void onSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        roundTime = 30f;
        score = 0;
        lives = 3;

    }
    void OnDisable()
    {
        roundTime = 30f;
        SceneManager.sceneLoaded -= onSceneLoaded;
    }

    // Update is called once per frame
    void Update()
    {
        title.text = SceneManager.GetActiveScene().name;
      
        roundTime -= Time.deltaTime;
        try {
            timerText.GetComponent<Text>().text = "Time remaining: " + roundTime.ToString();
        }
        catch(Exception e)
        {
            Debug.Log(e);
        }
        
        if ((lives <= 0 && SceneManager.GetActiveScene().name == "Level 1") || (lives <= 0 && SceneManager.GetActiveScene().name == "Level 3"))
        {
            if (SceneManager.GetActiveScene().name == "Level 1")
            {
                round1 = score;
                round1score.text = round1.ToString();
                round2score.text = round2.ToString();
                round3score.text = round3.ToString();
                getReward();
                finalScore = round1;
                final.text = finalScore.ToString();
                //Time.timeScale = 0;

            }
            else
            { 
                if (SceneManager.GetActiveScene().name == "Level 3")
                {
                    round3 = score;
                    round1score.text = round1.ToString();
                    round2score.text = round2.ToString();
                    round3score.text = round3.ToString();
                    getReward();
                    finalScore += round2;
                    final.text = finalScore.ToString();
                    //Time.timeScale = 0;

                }
                
            }
        }
        if (roundTime <= 0 && SceneManager.GetActiveScene().name == "Level 2")
        {
            roundTime = 0;
            if (SceneManager.GetActiveScene().name == "Level 2")
                {
                    round2 = score;
                    round1score.text = round1.ToString();
                    round2score.text = round2.ToString();
                    round3score.text = round3.ToString();
                    getReward();
                    finalScore += round2;
                    final.text = finalScore.ToString();
                    //Time.timeScale = 0;
                }
                
            
        }
    }

    void getReward()
    {
        if (score > 20000)
        {
            rewardText.text = rewardL;
        }
        else if (score > 5000)
        {
            rewardText.text = rewardM;
        }
        else if (score > 1000)
        {
            rewardText.text = rewardS;
        }
        else { rewardText.text = "Score higher to earn a reward"; }
    }

    public void addScore()
    {
        count++;
        if (count >= 3)
        {
            count = 0;
            combo++;
        }
        score += 100 * combo;
    }
    public void penalise()
    {
        combo = 1;
        count = 0;
        lives--;
    }

}


