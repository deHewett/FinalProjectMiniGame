using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public int score;
    public int combo;
    public int lives;
    private int count;
    public GameObject endScreen;
    public Text finalScoreText;
    public Text rewardText;

    private string rewardS = "SMALL";
    private string rewardM = "MEDIUM";
    private string rewardL = "LARGE";
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        combo = 1;
        lives = 3;
        count = 0;
        Scene[] scenes = SceneManager.GetAllScenes();
    }

    // Update is called once per frame
    void Update()
    {
        if(score > 25000)
        {
            SceneManager.
        }
        if(lives <= 0)
        {
            
            endScreen.SetActive(true);
            finalScoreText.text = score.ToString();
            
           
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
            Time.timeScale = 0;

        }
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
