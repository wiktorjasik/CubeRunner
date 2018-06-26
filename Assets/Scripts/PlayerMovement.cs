using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    int x = 0;

    public float forwardForce = 200f;
    public float sidewaysForce = 500f;

    void Start()
    {
        Input.simulateMouseWithTouches = enabled;
    }

    public void TurnRight()
    {
        x = 1;
    }

    public void TurnLeft()
    {
        x = -1;
    }

    public void ResetX()
    {
        x = 0;
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d") || x==1)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || x==-1)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }    
}
