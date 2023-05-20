using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeetleMovement : MonoBehaviour
{
    private Animator animator;
    public bool Dead = false;
    public Sprite DeadSprite;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3 (-1f, 0f, 0f);

        if(Dead == true)
        {
            animator.enabled = false;
            spriteRenderer.sprite = DeadSprite;
            Debug.Log("SpriteChanged");
            //    Time.timeScale = 0;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -2f, 0f);
        }
    }

}
