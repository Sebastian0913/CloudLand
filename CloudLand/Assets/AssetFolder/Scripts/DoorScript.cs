using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Dog;
    private bool Down = false;
    private bool Up = false;
    public movement gavinmovement;
    private Vector3 DogOriginal;
    // Start is called before the first frame update
    void Start()
    {
        DogOriginal = Dog.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gavinmovement.goal > 0)
        {
            Doggy();

        }
       

    }

    private void Doggy()
    {
        if (Down == false)
        {
            if (Player.transform.position.x >= gameObject.transform.position.x - 2f && Player.transform.position.x <= gameObject.transform.position.x + 2f)
            {
                Down = true;
            }
        }

        if (Down == true)
        {
            if (Dog.transform.position.y > gameObject.transform.position.y + 2 && Up == false)
            {
                Dog.transform.position += new Vector3(0, -5 * Time.deltaTime, 0);
            }

            if (Dog.transform.position.y <= gameObject.transform.position.y + 2)
            {
                Up = true;

            }

            if (Up == true)
            {
                Dog.transform.position += new Vector3(0, 2 * Time.deltaTime, 0);
                if (Dog.transform.position.y >= DogOriginal.y)
                {
                    Up = false;
                    Down = false;
                }
            }
        }
    }
}
