using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // This is reference to the rigidbody component called "rb"

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    //We marked this as "Fixed Update" because we are using it to mess with physics
    void FixedUpdate()
    {
        rb.AddForce(0,0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d")) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
