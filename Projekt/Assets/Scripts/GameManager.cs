using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Bson;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ValueChangedEvent : UnityEvent<int>
{
};

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private static int nextScene = 2;
    private int _guesses = 3;
    private int _nonvrpoints = 0;
    private int _npcs = 20;

    public ValueChangedEvent guessesChanged = new ValueChangedEvent();
    public ValueChangedEvent nonvrpointsChanged = new ValueChangedEvent();

    public int guesses
    {
        get { return _guesses; }
    }

    public int nonvrpoints
    {
        get { return _nonvrpoints; }
    }

    public int npcs
    {
        get { return _npcs; }
    }


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        SceneManager.LoadScene(nextScene);
    }

    public static void Load()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0);
    }

    public void ChangeGuesses(bool b)
    {
        if (b)
        {
            if (guesses < 3)
            {
                _guesses++;
                guessesChanged.Invoke(guesses);
            }
        }
        else
        {
            _guesses--;
            if (guesses > 0)
            {
                guessesChanged.Invoke(guesses);
            }
        }

        if (guesses <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void ChangeNPCS(int val)
    {
        _npcs = val;
    }

    public void VRPlayerWon()
    {
        SceneManager.LoadScene(2);
    }

    public void ResetGame()
    {
        _guesses = 3;
        _nonvrpoints = 0;
        SceneManager.LoadScene(2);
    }

    public void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            ResetGame();
        }

        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Collectible()
    {
        if (_nonvrpoints < 3)
        {
            _nonvrpoints += 1;
            nonvrpointsChanged.Invoke(nonvrpoints);
        }

        if (_nonvrpoints == 3)
        {
            SceneManager.LoadScene(3);
        }

        Debug.Log(_nonvrpoints);
    }
}