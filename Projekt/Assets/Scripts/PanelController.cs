using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PanelController : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;
    public Slider slider4;
    public GameObject nonvrmainpanel;
    public GameObject nonvrhowto1panel;
    public GameObject nonvrhowto2panel;
    public GameObject nonvrsettingspanel;

    public GameObject vrmainpanel;
    public GameObject vrhowto1panel;
    public GameObject vrhowto2panel;
    public GameObject vrsettingspanel;

    public GameObject vrmainpanel2;
    public GameObject vrhowto1panel2;
    public GameObject vrhowto2panel2;
    public GameObject vrsettingspanel2;

    public GameObject vrmainpanel3;
    public GameObject vrhowto1panel3;
    public GameObject vrhowto2panel3;
    public GameObject vrsettingspanel3;

    public GameObject vrmainpanel4;
    public GameObject vrhowto1panel4;
    public GameObject vrhowto2panel4;
    public GameObject vrsettingspanel4;

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

        vrmainpanel2.SetActive(true);
        vrhowto1panel2.SetActive(false);
        vrhowto2panel2.SetActive(false);
        vrsettingspanel2.SetActive(false);

        vrmainpanel3.SetActive(true);
        vrhowto1panel3.SetActive(false);
        vrhowto2panel3.SetActive(false);
        vrsettingspanel3.SetActive(false);

        vrmainpanel4.SetActive(true);
        vrhowto1panel4.SetActive(false);
        vrhowto2panel4.SetActive(false);
        vrsettingspanel4.SetActive(false);
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

        vrsettingspanel2.SetActive(true);
        vrmainpanel2.SetActive(false);
        vrhowto1panel2.SetActive(false);
        vrhowto2panel2.SetActive(false);

        vrsettingspanel3.SetActive(true);
        vrmainpanel3.SetActive(false);
        vrhowto1panel3.SetActive(false);
        vrhowto2panel3.SetActive(false);

        vrsettingspanel4.SetActive(true);
        vrmainpanel4.SetActive(false);
        vrhowto1panel4.SetActive(false);
        vrhowto2panel4.SetActive(false);

        slider1.value = GameManager.instance.npcs;
        slider2.value = GameManager.instance.npcs;
        slider3.value = GameManager.instance.npcs;
        slider4.value = GameManager.instance.npcs;
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

        vrmainpanel2.SetActive(true);
        vrhowto1panel2.SetActive(false);
        vrhowto2panel2.SetActive(false);
        vrsettingspanel2.SetActive(false);

        vrmainpanel3.SetActive(true);
        vrhowto1panel3.SetActive(false);
        vrhowto2panel3.SetActive(false);
        vrsettingspanel3.SetActive(false);

        vrmainpanel4.SetActive(true);
        vrhowto1panel4.SetActive(false);
        vrhowto2panel4.SetActive(false);
        vrsettingspanel4.SetActive(false);
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

        vrhowto1panel2.SetActive(true);
        vrmainpanel2.SetActive(false);
        vrhowto2panel2.SetActive(false);
        vrsettingspanel2.SetActive(false);

        vrhowto1panel3.SetActive(true);
        vrmainpanel3.SetActive(false);
        vrhowto2panel3.SetActive(false);
        vrsettingspanel3.SetActive(false);

        vrhowto1panel4.SetActive(true);
        vrmainpanel4.SetActive(false);
        vrhowto2panel4.SetActive(false);
        vrsettingspanel4.SetActive(false);
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

        vrhowto2panel2.SetActive(true);
        vrmainpanel2.SetActive(false);
        vrhowto1panel2.SetActive(false);
        vrsettingspanel2.SetActive(false);

        vrhowto2panel3.SetActive(true);
        vrmainpanel3.SetActive(false);
        vrhowto1panel3.SetActive(false);
        vrsettingspanel3.SetActive(false);

        vrhowto2panel4.SetActive(true);
        vrmainpanel4.SetActive(false);
        vrhowto1panel4.SetActive(false);
        vrsettingspanel4.SetActive(false);
    }
}