using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ScoreText;
    public GameObject GOpanel;
    public GameObject ContinueButton;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public Text ScoreTextWIn;
    public Text WinText;
    public GameObject input;
    public GameObject SVBT;

    public void SetScoreText(string txt)
    {
        if (ScoreText)
            ScoreText.text = txt;
    }
    public void SetScoreText1(string txt)
    {
        if (ScoreTextWIn)
            ScoreTextWIn.text = txt;
    }
    public void ShowGameOver()
    {
        if (GOpanel)
            GOpanel.SetActive(true);
    }
    public void GameWin(string a)
    {
        if(ScoreTextWIn)
        {
            ScoreTextWIn.text = a;
        }
    }
    public void WinTextt(string b)
    {
        if(WinText)
        {
            WinText.text = b;
        }
    }
    public void ShowIP()
    {
        if (input)
        {
            input.SetActive(true);
        }
    }
    public void ShowSvButton()
    {
        if(SVBT)
        {
            SVBT.SetActive(true);
        }
    }    
 
    public void ShowReplay2()
    {
        if(a)
        {
            a.SetActive(true);
        }
    }
    public void ShowExit()
    {
        if(b)
        {
            b.SetActive(true);
        }
    }
    public void ShowHome()
    {
        if(c)
        {
            c.SetActive(true);
        }
    }

}
