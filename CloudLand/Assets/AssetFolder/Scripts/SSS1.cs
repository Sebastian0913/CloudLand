using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SSS1 : MonoBehaviour
{
    private Image SPLetter;
    private Image SPButton;
    public Sprite spriteVoid;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;

    public Button BL1;
    public Button BL2;
    public Button BL3;
    public Button BL4;
    public Button BL5;

    public Button B1;
    public Button B2;
    public Button B3;
    public Button B4;
    public Button B5;
    private int correctCounter = 0;
    private int TempIndexLetter = 0;
    private int TempIndexbutton = -1;
    private int PlayCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayCounter == 2)
        {
            if(TempIndexbutton == TempIndexLetter)
            {
                Debug.Log("Correct");
                PlayCounter = 0;
                correctCounter++;
                DisableButton(TempIndexbutton);
            }
            else
            {
                Debug.Log("InCorrect");
                PlayCounter = 0;
            }
        }
    }

    public void ClickLetter1()
    {
        if(PlayCounter < 1)
        {
            TempIndexLetter = 1;
            PlayCounter++;
        }
    }

    public void ClickLetter2()
    {
        if(PlayCounter < 1)
        {
            TempIndexLetter = 2;
            PlayCounter++;
        }
    }

    public void ClickLetter3()
    {
        if(PlayCounter < 1)
        {
            TempIndexLetter = 3;
            PlayCounter++;
        }
    }

    public void ClickLetter4()
    {
        if(PlayCounter < 1)
        {
            TempIndexLetter = 4;
            PlayCounter++;
        }
    }

    public void ClickLetter5()
    {
        if(PlayCounter < 1)
        {
            TempIndexLetter = 5;
            PlayCounter++;
        }
    }
    
    /// ///////////////////////////

    public void Click1()
    {
        if(PlayCounter > 0)
        {
            TempIndexbutton = 1;
            PlayCounter++;
        }
    }

    public void Click2()
    {
        if(PlayCounter > 0)
        {
            TempIndexbutton = 2;
            PlayCounter++;
        }
    }

    public void Click3()
    {
        if(PlayCounter > 0)
        {
            TempIndexbutton = 3;
            PlayCounter++;
        }

    }

    public void Click4()
    {
        if(PlayCounter > 0)
        {
            TempIndexbutton = 4;
            PlayCounter++;
        }
    }

    public void Click5()
    {
        if(PlayCounter > 0)
        {
            TempIndexbutton = 5;
            PlayCounter++;
        }
    }

    public void ClickTotalFail()
    {
        TempIndexbutton = -100;
        PlayCounter++;
    }

    private void DisableButton(int Index)
    {
        if(Index == 1)
        {
            SPLetter = BL1.GetComponent<Image>();
            SPLetter.sprite = spriteVoid;
            SPButton = B1.GetComponent<Image>();
            SPButton.sprite = sprite1;
            B1.enabled = false;
            BL1.enabled = false;
        }
        else if (Index == 2)
        {
            SPLetter = BL2.GetComponent<Image>();
            SPLetter.sprite = spriteVoid;
            SPButton = B2.GetComponent<Image>();
            SPButton.sprite = sprite2;
            B2.enabled = false;
            BL2.enabled = false;
        }
        else if (Index == 3)
        {
            SPLetter = BL3.GetComponent<Image>();
            SPLetter.sprite = spriteVoid;
            SPButton = B3.GetComponent<Image>();
            SPButton.sprite = sprite3;
            B3.enabled = false;
            BL3.enabled = false;
        }
        else if (Index == 4)
        {
            SPLetter = BL4.GetComponent<Image>();
            SPLetter.sprite = spriteVoid;
            SPButton = B4.GetComponent<Image>();
            SPButton.sprite = sprite4;
            B4.enabled = false;
            BL4.enabled = false;
        }
        else if (Index == 5)
        {
            SPLetter = BL5.GetComponent<Image>();
            SPLetter.sprite = spriteVoid;
            SPButton = B5.GetComponent<Image>();
            SPButton.sprite = sprite5;
            B5.enabled = false;
            BL5.enabled = false;
        }
    }

    //public void Click6()
    //{
    //    TempIndexbutton = 6;
    //    PlayCounter++;
    //}

    //public void Click7()
    //{
    //    TempIndexbutton = 7;
    //    PlayCounter++;
    //}

    //public void Click8()
    //{
    //    TempIndexbutton = 8;
    //    PlayCounter++;
    //}

    //public void Click9()
    //{
    //    TempIndexbutton = 9;
    //    PlayCounter++;
    //}

    //public void Click10()
    //{
    //    TempIndexbutton = 10;
    //    PlayCounter++;
    //}

    //public void Click11()
    //{
    //    TempIndexbutton = 11;
    //    PlayCounter++;
    //}
    //public void Click12()
    //{
    //    TempIndexbutton = 12;
    //    PlayCounter++;
    //}

    //public void Click13()
    //{
    //    TempIndexbutton = 13;
    //    PlayCounter++;
    //}

    //public void Click14()
    //{
    //    TempIndexbutton = 14;
    //    PlayCounter++;
    //}

    //public void Click15()
    //{
    //    TempIndexbutton = 15;
    //    PlayCounter++;
    //}

    //public void Click16()
    //{
    //    TempIndexbutton = 16;
    //    PlayCounter++;
    //}

    //public void Click17()
    //{
    //    TempIndexbutton = 17;
    //    PlayCounter++;
    //}

    //public void Click18()
    //{
    //    TempIndexbutton = 18;
    //    PlayCounter++;
    //}

    //public void Click19()
    //{
    //    TempIndexbutton = 19;
    //    PlayCounter++;
    //}

    //public void Click20()
    //{
    //    TempIndexbutton = 20;
    //    PlayCounter++;
    //}

    //public void Click21()
    //{
    //    TempIndexbutton = 21;
    //    PlayCounter++;
    //}

    //public void Click22()
    //{
    //    TempIndexbutton = 22;
    //    PlayCounter++;
    //}

    //public void Click23()
    //{
    //    TempIndexbutton = 23;
    //    PlayCounter++;
    //}

    //public void Click24()
    //{
    //    TempIndexbutton = 24;
    //    PlayCounter++;
    //}

    //public void Click25()
    //{
    //    TempIndexbutton = 25;
    //    PlayCounter++;
    //}

    //public void Click26()
    //{
    //    TempIndexbutton = 26;
    //    PlayCounter++;
    //}
}
