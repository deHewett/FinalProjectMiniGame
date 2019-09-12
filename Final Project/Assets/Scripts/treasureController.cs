using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureController : MonoBehaviour
{
    gameController gc;
    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<gameController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("COLLISION PLAYER");
            gc.penalise();
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "End Zone")
        {
            Debug.Log("COLLISION END ZONE");
            Destroy(this.gameObject);
        }
    }
}
