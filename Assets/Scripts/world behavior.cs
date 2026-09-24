using UnityEngine;

public class worldbehavior : MonoBehaviour
{
    public SpriteRenderer playerSprite;
    public float Speed;
    public float health = 5;
    public float score = 0;
    public float timer = 0;
    public GameObject coin;

    public string startText = "Hello, World!";
    // Start is called once before the first execution of Update after the MonoBehaviour is created   
    void Start()
    {
        playerSprite.color = Color.white;
        Debug.Log(startText);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        { playerSprite.color = Color.red; }

        timer += Time.deltaTime;
        if (timer > 3f)
        {
            Vector2 pos;
            pos.x = Random.Range(-9, 9);
            pos.y = Random.Range(-4, 5);
            Instantiate(coin, pos, Quaternion.identity);
            timer = 0;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit an Object");
        if (collision.gameObject.tag == "spike")
        {
            health--;
        }

        if (collision.gameObject.tag == "coin")
        {
            score++;
            Destroy(collision.gameObject);

        }
    }
}