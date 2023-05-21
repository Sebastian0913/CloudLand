using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePowerUp : MonoBehaviour
{
    private SpriteRenderer SR;
    public Sprite TouchedSprite;
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            SR.sprite = TouchedSprite;
        }
    }
}
