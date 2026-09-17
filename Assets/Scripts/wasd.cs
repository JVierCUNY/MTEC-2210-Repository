using UnityEngine;
using UnityEngine.InputSystem;

public class wasd : MonoBehaviour
{

    public float speed = 10f;
    public Vector2 direction;

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
        

        if (Keyboard.current.wKey.isPressed)
        {
            direction += Vector2.up * speed;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            direction += Vector2.down * speed;
        }
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
        float rot = 0f;
        if (Keyboard.current.qKey.isPressed)
        {
            rot += 2f;
        }
        if (Keyboard.current.eKey.isPressed)
        {
            rot -= 2f;
        }

        transform.Rotate(new Vector3(0, 0, rot));

        //if (Keyboard.current.spaceKey.wasPressedThisFrame)
		{
            //executes a jump

		}
    }
}

