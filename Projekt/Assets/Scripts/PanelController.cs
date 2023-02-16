using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PanelController : MonoBehaviour
{
    public Slider slider;
    public GameObject mainpanel;
    public GameObject howto1panel;
    public GameObject howto2panel;
    public GameObject settingspanel;

    void Awake()
    {
        mainpanel.SetActive(true);
        howto1panel.SetActive(false);
        howto2panel.SetActive(false);
        settingspanel.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }
    
    public void EnterSettings()
    {
        slider.value =GameManager.instance.npcs;
        mainpanel.SetActive(false);
        howto1panel.SetActive(false);
        howto2panel.SetActive(false);
        settingspanel.SetActive(true);
    }

    public void EnterMain()
    {
        mainpanel.SetActive(true);
        howto1panel.SetActive(false);
        howto2panel.SetActive(false);
        settingspanel.SetActive(false);
    }

    public void EnterHowto1()
    {
        mainpanel.SetActive(false);
        howto1panel.SetActive(true);
        howto2panel.SetActive(false);
        settingspanel.SetActive(false);
    }
    
    public void EnterHowto2()
    {
        mainpanel.SetActive(false);
        howto1panel.SetActive(false);
        howto2panel.SetActive(true);
        settingspanel.SetActive(false);
    }
}
