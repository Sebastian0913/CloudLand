using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemyMovement : MonoBehaviour
{
    public GameObject eyes;
    public bool Move = false;
    public int SwitchCounter = 0;
    public int trueCounter = 0;
    private Animator animator;
    public bool Dead = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Dead == false)
        {
            if (Move == true && SwitchCounter % 2 == 0)
            {
                gameObject.transform.localScale = new Vector3(2, 2, 2);
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(-5, 0, 0);
            }
            else if (Move == false && SwitchCounter % 2 != 0)
            {
                gameObject.transform.localScale = new Vector3(-2, 2, 2);
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(5, 0, 0);
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
                trueCounter ++;
            }
        }
    }
}
