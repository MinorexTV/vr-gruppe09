using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GuessesController : MonoBehaviour
{
    [SerializeField] private GameObject guess1;
    [SerializeField] private GameObject guess2;
    [SerializeField] private GameObject guess3;

    private void Start()
    {
        guess1.SetActive(true);
        guess2.SetActive(true);
        guess3.SetActive(true);
        GameManager.instance.guessesChanged.AddListener(UpdateGuesses);
    }

    void UpdateGuesses(int value)
    {
        if (value == 3)
        {
            guess1.SetActive(true);
            guess2.SetActive(true);
            guess3.SetActive(true);
        }
        else if (value == 2)
        {
            guess1.SetActive(false);
            guess2.SetActive(true);
            guess3.SetActive(true);
        }
        else if (value == 1)
        {
            guess1.SetActive(false);
            guess2.SetActive(false);
            guess3.SetActive(true);
        }
    }
    /*TMP_Text textComp;
    void Start()
    {
        textComp = GetComponent<TMP_Text>();
       GameManager.instance.guessesChanged.AddListener(UpdateText);
       textComp.text = "Versuche: " + GameManager.instance.guesses;
    }

    // Update is called once per frame
    public void UpdateText(int value)
    {
        textComp.text = "Versuche: " + value;
    }*/
}