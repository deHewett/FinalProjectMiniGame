using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Transform transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);
        if(transform.position.x > 9.3)
        {
            transform.position = new Vector3(-9.2f, -4.4f, 0);
        }
        if (transform.position.x < -9.3)
        {
            transform.position = new Vector3(9.2f, -4.4f, 0);
        }
    }
}
