using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{

    Rigidbody rb;
    public int speed = 0;
    public int turningSpeed = 0;

    UImanager m_ui;
    MainButton m_a;
    int m_score = 0;
    int m_scoreWin = 0;


    public AudioSource Aus;
    public AudioClip Ascore;
    public AudioClip Adie;
    public AudioClip Awin;
   
    // Start is called before the first frame update
    void Start()
    {
        // int i = 3;
        rb = GetComponent<Rigidbody>();
        m_ui = FindObjectOfType<UImanager>();
     

    }

    // Update is called once per frame
 
    public int getScore()
    {
        return m_score;
    }
    void Update()
    {
        float a = Input.GetAxis("Horizontal");
        rb.AddForce(0f, 0f, turningSpeed * a * Time.deltaTime, ForceMode.VelocityChange);
       
    }
    private void FixedUpdate()
    {
        rb.AddForce(-speed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if( other.CompareTag("Score"))
        {
            other.gameObject.SetActive(false);
            m_score++;
            m_ui.SetScoreText("Score: " + m_score);
            if(Aus && Ascore)
            {
                Aus.PlayOneShot(Ascore);
            }
        }
        if(other.CompareTag("Speed"))
        {
            speed = speed * (4 / 3);
        }
        else if(other.CompareTag("Down"))
        {
            speed = speed / (3 / 4);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("VatCan"))
        {
            
            m_scoreWin = m_score;
            this.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            rb.AddForce(0 * Time.deltaTime, 0, 0);
            m_ui.GameWin("Point: " + m_scoreWin);
            m_ui.ShowGameOver();
            m_ui.ShowReplay2();
            m_ui.ShowExit();
            m_ui.ShowHome();
            m_ui.ShowIP();
            m_ui.ShowSvButton();
            if(Aus && Adie)
            {
                Aus.PlayOneShot(Adie);
            }
        }
        if(collision.gameObject.CompareTag("YouWin"))
        
        {
            
            m_scoreWin = m_score;
            m_ui.WinTextt("YOU WIN");
            m_ui.GameWin("Point: " + m_scoreWin);
            this.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            rb.AddForce(1 * Time.deltaTime, 0, 0);
         
            m_ui.ShowReplay2();
            m_ui.ShowExit();
            m_ui.ShowHome();
            m_ui.ShowIP();
            m_ui.ShowSvButton();

           if(Aus && Awin)
            {
                Aus.PlayOneShot(Awin);
            }

        }
    }
    public void Replay()
    {
        SceneManager.LoadScene("map2");
    }
    public void Replay1()
    {
        SceneManager.LoadScene("map1");
    }
    public void Replay2()
    {
        SceneManager.LoadScene("map3");
    }
    public void Replay1tb()
    {
        SceneManager.LoadScene("Map1_TB");
    }
    public void Replay2tb()
    {
        SceneManager.LoadScene("Map2_TB");
    }
    public void Replay3tb()
    {
        SceneManager.LoadScene("Map3_TB");
    }
    public void Replay1Kho()
    {
        SceneManager.LoadScene("Map1_Kho");
    }
    public void Replay2Kho()
    {
        SceneManager.LoadScene("Map2_Kho");
    }
    public void Replay3Kho()
    {
        SceneManager.LoadScene("Map3_Kho");
    }
    public void ReSum()
    {
        Time.timeScale = 0f;
        Aus.Pause();
    }
    public void Continue()
    {
        Time.timeScale = 1f;
        Aus.Play();
    }
  
    public void TurnOff()
    {
        Aus.mute = !Aus.mute;
        
    }
}
   

