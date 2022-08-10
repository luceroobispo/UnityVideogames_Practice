using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    Rigidbody2D rb;

    bool Grounded = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame 
    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal"); //move left or rigth
        rb.velocity = new Vector2(MoveX * Speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && Grounded == true) {
            //Jump
            rb.AddForce(transform.up * JumpForce);
            Grounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="Ground") {
            Grounded = true;
        }
    }
}
