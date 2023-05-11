using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star_scripts : MonoBehaviour
{
    private BoxCollider2D box;
    [SerializeField] private LayerMask layer;
    public int value;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (box.IsTouchingLayers(layer))
        {
           //Invoke("kill", 0.1f);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (box.IsTouchingLayers(layer)) 
        {
            kill();
            movement.instance.collect(value);
        
        }
    }

    private void kill() 
    {
        DestroyObject(gameObject);



    }

}
