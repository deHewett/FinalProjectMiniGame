using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonHandler : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    public void nextScene()
    {
        if(SceneManager.GetActiveScene().name == "Level 1")
        {
            SceneManager.LoadScene("Level 2");
            
        }
        if (SceneManager.GetActiveScene().name == "Level 2")
        {
            SceneManager.LoadScene("Level 3");
        }
        if (SceneManager.GetActiveScene().name == "Level 3")
        {
            Application.Quit();
        }
    }
}
