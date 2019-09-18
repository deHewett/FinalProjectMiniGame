using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonHandler : MonoBehaviour
{
    Scene currentScene;
    string sceneName;
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    public void nextScene()
    {
        if(sceneName == "1")
        {
            SceneManager.LoadScene("2");
        }
        if (sceneName == "2")
        {
            SceneManager.LoadScene("3");
        }
        if (sceneName == "3")
        {
            Application.Quit();
        }
    }
}
