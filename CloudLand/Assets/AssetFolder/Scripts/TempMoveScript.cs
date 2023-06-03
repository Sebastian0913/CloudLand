using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempMoveScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private float Horizontal;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        if (Horizontal < 0)
        {
            Debug.Log(Horizontal);
            rb.velocity = new Vector3(Horizontal * 5f, 0f , 0f);
        }
        else if(Horizontal > 0)
        {
            rb.velocity = new Vector3(Horizontal * 5f, 0f, 0f);
        }
    }
}
