using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemyMovement : MonoBehaviour
{
   // public GameObject eyes;
    public GameObject Left;
    public GameObject Right;
    private Vector3 left;
    private Vector3 right;
    private bool Move = false;
    private int SwitchCounter = 0;
    private int trueCounter = 0;
    private Animator animator;
    public bool Dead = false;
    private bool Walk = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        left = Left.transform.position;
        right = Right.transform.position;   

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Dead == false && Walk == true)
        {
            if (Move == true && gameObject.transform.position.x >= left.x)
            {
                gameObject.transform.localScale = new Vector3(2, 2, 2);
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(-5, 0, 0);
            }
            else if(Move == true && gameObject.transform.position.x <= left.x)
            {
                Move = false;
            }
            
            if (Move == false && gameObject.transform.position.x <= right.x)
            {
                gameObject.transform.localScale = new Vector3(-2, 2, 2);
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(5, 0, 0);
            }
            else if(Move == false && gameObject.transform.position.x >= right.x)
            {
                Move = true;
            }
            //Debug.Log("SwitchCounter " + SwitchCounter);
            //Debug.Log("SwitchCounterRem " + SwitchCounter % 2);

        }
        else 
        if (Dead == true)
        {
            animator.enabled = false;
//            gameObject.transform.localScale = new Vector3(transform.localScale.x, -transform.localScale.y, transform.localScale.z);
            Debug.Log("SpriteChanged");
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -2f, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Platform")
        {
            if(trueCounter < 1)
            {
                Move = true;
                Walk = true;
                trueCounter ++;
            }
        }
    }
}
