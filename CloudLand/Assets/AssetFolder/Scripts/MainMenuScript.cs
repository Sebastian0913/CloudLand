using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject Bound;
    public GameObject GoButton;
    public GameObject GoPrefab;
    private GameObject GoObject;
    private bool StartMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(StartMoving == true)
        {
            GoObject.transform.position += new Vector3(5f * Time.deltaTime, 0f, 0f);
        }
        if (GoObject != null)
        {
            if (GoObject.transform.position.x >= Bound.transform.position.x)
            {
                StartMoving = false;
                SceneManager.LoadScene("LoadingScene");
            }
        }

    }

    public void ClickGo()
    {
        GoButton.SetActive(false);
        GoObject = Instantiate(GoPrefab, gameObject.transform.position, Quaternion.identity);
        StartMoving = true;
    }
}
