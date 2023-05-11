using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    private float dirX = 0f;
    private float speed = 7f;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);
        Flip();
    }

    private void Flip()
    {
        if (dirX > 0f)
        {


            sprite.flipX = false;

        }
        else if (dirX < 0f)
        {

            sprite.flipX = true;

        }
    }
}
