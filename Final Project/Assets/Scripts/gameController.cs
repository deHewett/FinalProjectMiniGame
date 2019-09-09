using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public int score;
    public int combo;
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        combo = 0;
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
