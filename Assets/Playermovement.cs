
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public GameManager gm;
    public Rigidbody rb;
    
    public float runspeed = 500f;
    public float strafeSpeed = 500f;
    public float jumpForce = 15f;

    protected bool strafeLeft = false;
    protected bool strafeRight = false;
    protected bool doJump = false;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            gm.EndGame();
            Debug.Log("Game Over!");
        }
    }
        

    void Update()
    {
        if (Input.GetKey("a")) 
        { 
            strafeLeft = true; 
        }else 
        {
            strafeLeft = false;
        }
        if (Input.GetKey("d"))
        {
            strafeRight = true;
        }else
        {
            strafeRight = false;
        }

        if(Input.GetKeyDown("space")) 
        {
            doJump = true;
        }
        if(transform.position.y < -5f)
        {
            gm.EndGame();
            Debug.Log("Game Over!");
        }
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, runspeed * Time.deltaTime);
        if (strafeLeft)
        {
            rb.AddForce(-strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (strafeRight)
        {
            rb.AddForce(strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (doJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            doJump = false;
        }
    }
}
