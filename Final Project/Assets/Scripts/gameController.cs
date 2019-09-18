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
    public GameObject endScreen;
    public Text round1score;
    public Text round2score;
    public Text round3score;
    public Text final;
    public Text rewardText;

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
        DontDestroyOnLoad(this);
        score = 0;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(lives <= 0)
        {
            endScreen.SetActive(true);
            if (round1 == 0)
            {
                round1 = score;
                round1score.text = round1.ToString();
                getReward();
                finalScore = round1;
                final.text = finalScore.ToString();
                Time.timeScale = 0;

            }
            else 
            {
                if (round2 == 0) {
                    round2 = score;
                    round2score.text = round2.ToString();
                    getReward();
                    finalScore += round2;
                    final.text = finalScore.ToString();
                    Time.timeScale = 0;
                }
                else
                {
                    if (round3 == 0)
                    {
                        round3 = score;
                        round3score.text = round3.ToString();
                        getReward();
                        finalScore += round2;
                        final.text = finalScore.ToString();
                        Time.timeScale = 0;

                    }
                }        
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
