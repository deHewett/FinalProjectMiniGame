using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class comboDisplay : MonoBehaviour
{
    gameController gc;
    public Text comboText;
    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<gameController>();
    }

    // Update is called once per frame
    void Update()
    {
        comboText.text = "Combo: x" + gc.combo;
    }
}
