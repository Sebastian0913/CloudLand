using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeSmallEnemy : MonoBehaviour
{
    private SmallEnemyMovement SEnemyScript;
    // Start is called before the first frame update
    void Start()
    {
        SEnemyScript = FindAnyObjectByType<SmallEnemyMovement>();
    }

    // Update is called once per frame
    

    private void FixedUpdate()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
        
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.collider.tag == "Platform")
    //    {
    //        Debug.Log("Collision");
            
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
        {
            Debug.Log("Collision");

        }
    }

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.collider.tag == "Platform")
    //    {
    //        Debug.Log("No Collision");
    //        SEnemyScript.SwitchCounter++;
    //        if(SEnemyScript.SwitchCounter % 2 != 0)
    //        {
    //            SEnemyScript.Move = false;

    //        }
    //        else
    //        {
    //            SEnemyScript.Move = true;
    //        }
    //        //Debug.Log("Move " + SEnemyScript.Move);
    //    }
    //}

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
        {
            Debug.Log("No Collision");
            SEnemyScript.SwitchCounter++;
            if (SEnemyScript.SwitchCounter % 2 != 0)
            {
                SEnemyScript.Move = false;

            }
            else
            {
                SEnemyScript.Move = true;
            }
            //Debug.Log("Move " + SEnemyScript.Move);
        }
    }


}
