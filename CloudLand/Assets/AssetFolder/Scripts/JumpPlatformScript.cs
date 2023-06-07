using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatformScript : MonoBehaviour
{
    private float JumpForce = 10f;
    private Rigidbody2D playerRb;
    private Animator animator;
    private SoundManager soundManager;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        soundManager = FindObjectOfType<SoundManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            soundManager.SelectAudio(1, 0.5f);

            playerRb = collision.collider.GetComponent<Rigidbody2D>();
            if(playerRb != null)
            {
                Vector2 velocity = playerRb.velocity;
                velocity.y = JumpForce;
                playerRb.velocity = velocity;
                animator.SetBool("DisplayBounce", true);
                Invoke("DisableAnimation", 0.45f);
            }
        }
    }

    void DisableAnimation()
    {
        animator.SetBool("DisplayBounce", false);
    }
    
}
