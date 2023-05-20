using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeetleSSpot : MonoBehaviour
{
    private BeetleMovement BeetleMovementScript;
    // Start is called before the first frame update
    void Start()
    {
        BeetleMovementScript = FindObjectOfType<BeetleMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Beetle Enemy Dead");
            BeetleMovementScript.Dead = true;
            
        }
    }
}
