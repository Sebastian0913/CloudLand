using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    public Transform target;
    private float moveSpeed = 2f;
    public bool Begin = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Begin == true)
        {
            //Vector2 desiredPosition = target.position;
            //Vector2 smoothedPosition = Vector2.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            //transform.position = smoothedPosition;
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            if(transform.position == target.position)
            {
                Destroy(gameObject, 1f);
            }
            //if (transform.position.x >= target.position.x && transform.position.y >= target.position.y)
            //{
            //    Destroy(gameObject);
            //}
        }
    }

    
}
