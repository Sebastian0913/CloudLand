using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemyMovement : MonoBehaviour
{
    public GameObject eyes;
    public bool Move = false;
    public int SwitchCounter = 0;
    public int trueCounter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
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
