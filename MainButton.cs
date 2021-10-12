using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButton : MonoBehaviour
{
    public void map1_de()
    {
        Application.LoadLevel("map1");
    }
    public void map2_de()
    {
        Application.LoadLevel("map2");
    }
    public void map3_de()
    {
        Application.LoadLevel("map3");

    }
    public void map1_tb()
    {
        Application.LoadLevel("Map1_TB");
    }
    public void map2_tb()
    {
        Application.LoadLevel("Map2_TB");
    }
    public void map3_tb()
    {
        Application.LoadLevel("Map3_TB");
    }
    public void map1_kho()
    {
        Application.LoadLevel("Map1_Kho");
    }
    public void map2_kho()
    {
        Application.LoadLevel("Map2_Kho");
    }
    public void map3_kho()
    {
        Application.LoadLevel("Map3_Kho");
    }

    public void ColorBall()
    {
        Application.LoadLevel("ColorBall");
    }
    public void HomeBall()
    {
        Application.LoadLevel("Main");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
