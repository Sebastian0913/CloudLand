using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDummySSPot : MonoBehaviour
{
    private SmallEnemyMovement SEMovementScript;
    //private EyeSmallEnemy EyeScript;
    // Start is called before the first frame update
    void Start()
    {
        SEMovementScript = FindObjectOfType<SmallEnemyMovement>();
     //   EyeScript = FindObjectOfType<EyeSmallEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Dummy Red Enemy Dead");
            SEMovementScript.Dead = true;
            SEMovementScript.gameObject.transform.localScale = new Vector3(SEMovementScript.gameObject.transform.localScale.x, -SEMovementScript.gameObject.transform.localScale.y, SEMovementScript.gameObject.transform.localScale.z);
            gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;
            SEMovementScript.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
          //  EyeScript.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
}
