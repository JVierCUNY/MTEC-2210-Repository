using UnityEngine;
using UnityEngine.InputSystem;

public class wasd : MonoBehaviour
{

    public float speed = 0.3f;
    public float accel = 300f;
    public float accelTime = .3f;
    public bool grounded = false;
    public Vector2 direction;
    public Rigidbody2D littleGuy; 

    //we could declare keys as vars here


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // clean direction vector before figuring out WASD
        direction = Vector2.zero;
        

        //if (Keyboard.current.wKey.isPressed)
        //{
        //    direction += Vector2.up * speed;
        //}

        //if (Keyboard.current.sKey.isPressed)
        //{
        //    direction += Vector2.down * speed;
        //}
        if (Keyboard.current.aKey.isPressed)
        {
            direction += Vector2.left * speed;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            direction += Vector2.right * speed;
        }

        transform.Translate(direction);

        //but to rotatE?
        //float rot = 0f;
        //if (Keyboard.current.qKey.isPressed)
        //{
        //    rot += 2f;
        //}
        //if (Keyboard.current.eKey.isPressed)
        //{
        //    rot -= 2f;
        //}

        //transform.Rotate(new Vector3(0, 0, rot));

        //if (Keyboard.current.spaceKey.wasPressedThisFrame)
		{
            //executes a jump

		}
    }
void FixedUpdate()
{
    if (Keyboard.current.spaceKey.isPressed && grounded)
    {
        littleGuy.AddForce(Vector2.up * accel);
    }
}
void OnCollisionStay2D(Collision2D collision)
{
    //this runs any frame we stay in contact with an object
    if (collision.gameObject.tag == "ground")
    {
        grounded = true;
    }
}

private void OnCollisionExit2D(Collision2D collision)
{
    //this runs the frame we leave contact with an object
    if (collision.gameObject.tag == "ground")
    {
        grounded = false;
    }
}

}



