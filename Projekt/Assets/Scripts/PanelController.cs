using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PanelController : MonoBehaviour
{
    public Slider slider;
    public GameObject nonvrmainpanel;
    public GameObject nonvrhowto1panel;
    public GameObject nonvrhowto2panel;
    public GameObject nonvrsettingspanel;
    
    public GameObject vrmainpanel;
    public GameObject vrhowto1panel;
    public GameObject vrhowto2panel;
    public GameObject vrsettingspanel;

    void Awake()
    {
        nonvrmainpanel.SetActive(true);
        nonvrhowto1panel.SetActive(false);
        nonvrhowto2panel.SetActive(false);
        nonvrsettingspanel.SetActive(false);
        
        vrmainpanel.SetActive(true);
        vrhowto1panel.SetActive(false);
        vrhowto2panel.SetActive(false);
        vrsettingspanel.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }
    
    public void EnterSettings()
    {
        nonvrsettingspanel.SetActive(true);
        nonvrmainpanel.SetActive(false);
        nonvrhowto1panel.SetActive(false);
        nonvrhowto2panel.SetActive(false);
        
        vrsettingspanel.SetActive(true);
        vrmainpanel.SetActive(false);
        vrhowto1panel.SetActive(false);
        vrhowto2panel.SetActive(false);
        
        slider.value = GameManager.instance.npcs;
        
        
    }

    public void EnterMain()
    {
        nonvrmainpanel.SetActive(true);
        nonvrhowto1panel.SetActive(false);
        nonvrhowto2panel.SetActive(false);
        nonvrsettingspanel.SetActive(false);
        
        vrmainpanel.SetActive(true);
        vrhowto1panel.SetActive(false);
        vrhowto2panel.SetActive(false);
        vrsettingspanel.SetActive(false);
    }

    public void EnterHowto1()
    {
        nonvrhowto1panel.SetActive(true);
        nonvrmainpanel.SetActive(false);
        nonvrhowto2panel.SetActive(false);
        nonvrsettingspanel.SetActive(false);
        
        vrhowto1panel.SetActive(true);
        vrmainpanel.SetActive(false);
        vrhowto2panel.SetActive(false);
        vrsettingspanel.SetActive(false);
    }
    
    public void EnterHowto2()
    {
        nonvrhowto2panel.SetActive(true);
        nonvrmainpanel.SetActive(false);
        nonvrhowto1panel.SetActive(false);
        nonvrsettingspanel.SetActive(false);
        
        vrhowto2panel.SetActive(true);
        vrmainpanel.SetActive(false);
        vrhowto1panel.SetActive(false);
        vrsettingspanel.SetActive(false);
    }
}
