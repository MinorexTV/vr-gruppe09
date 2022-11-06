using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ValueChangedEvent : UnityEvent<int>
{
};
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private static int nextScene = 1;
    private int _guesses = 3;

    public ValueChangedEvent guessesChanged = new ValueChangedEvent();

    public int guesses
    {
        get { return _guesses; }
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
            _guesses++;
        }
        else
        {
            _guesses--;
        }

        guessesChanged.Invoke(guesses);

        if (guesses <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void VRPlayerWon()
    {
        SceneManager.LoadScene(2);
    }
    
}