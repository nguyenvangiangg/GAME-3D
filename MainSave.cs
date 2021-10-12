using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSave : MonoBehaviour
{
    public Text HightSCore;
    public Text ScoreText;

    public Text obj_text;
    public InputField display;
    ball player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<ball>();
        HightSCore.text = PlayerPrefs.GetInt("HightScore", 0).ToString();

        obj_text.text = PlayerPrefs.GetString("User_Name");
    }

    // Update is called once per frame
    public void Mainsave()
    {
        int score = player.getScore();
        ScoreText.text = score.ToString();

        if (score > PlayerPrefs.GetInt("HightScore", 0))
        {
            User();
            PlayerPrefs.SetInt("HightScore", score);
            HightSCore.text = score.ToString();
        }
    }

    public void User()
    {
        obj_text.text = display.text;
        PlayerPrefs.SetString("User_Name", obj_text.text);
    }
}
