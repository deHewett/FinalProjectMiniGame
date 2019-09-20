using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    public void begin()
    {
        SceneManager.LoadScene("Level 1");
    }
}
