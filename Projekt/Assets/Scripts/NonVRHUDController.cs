using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NonVRHUDController : MonoBehaviour

{
    [SerializeField] private GameObject coinSprite1;
    [SerializeField] private GameObject coinSprite2;
    [SerializeField] private GameObject coinSprite3;
    [SerializeField] private GameObject controllerSprite1;
    [SerializeField] private GameObject controllerSprite2;
    [SerializeField] private GameObject controllerSprite3;
    [SerializeField] private GameObject optionPanel;
    [SerializeField] private GameObject pausedPanel;


    private void Start()
    {
        optionPanel.SetActive(false);
        pausedPanel.SetActive(false);

        coinSprite1.SetActive(false);
        coinSprite2.SetActive(false);
        coinSprite3.SetActive(false);
        GameManager.instance.nonvrpointsChanged.AddListener(UpdateCoins);

        controllerSprite1.SetActive(true);
        controllerSprite2.SetActive(true);
        controllerSprite3.SetActive(true);
        GameManager.instance.guessesChanged.AddListener(UpdateController);
    }

    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (optionPanel.activeSelf)
            {
                optionPanel.SetActive(false);
                pausedPanel.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                optionPanel.SetActive(true);
                pausedPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public void EnterSettings()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    void UpdateCoins(int value)
    {
        if (value == 3)
        {
            coinSprite1.SetActive(true);
            coinSprite2.SetActive(true);
            coinSprite3.SetActive(true);
        }
        else if (value == 2)
        {
            coinSprite1.SetActive(true);
            coinSprite2.SetActive(true);
            coinSprite3.SetActive(false);
        }
        else if (value == 1)
        {
            coinSprite1.SetActive(true);
            coinSprite2.SetActive(false);
            coinSprite3.SetActive(false);
        }
    }

    void UpdateController(int value)
    {
        if (value == 3)
        {
            controllerSprite1.SetActive(true);
            controllerSprite2.SetActive(true);
            controllerSprite3.SetActive(true);
        }
        else if (value == 2)
        {
            controllerSprite1.SetActive(true);
            controllerSprite2.SetActive(true);
            controllerSprite3.SetActive(false);
        }
        else if (value == 1)
        {
            controllerSprite1.SetActive(true);
            controllerSprite2.SetActive(false);
            controllerSprite3.SetActive(false);
        }
    }
}