using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class livesDisplay : MonoBehaviour
{
    gameController gc;
    public Text liveText;
    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<gameController>();
    }

    // Update is called once per frame
    void Update()
    {
        liveText.text = "Lives: " + gc.lives;
    }
}
