using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRAudioController : MonoBehaviour
{
   [SerializeField] private AudioClip wrongGuess;
   [SerializeField] private AudioClip goldenGuess;
    private int currentGuesses;
    void Start()
    {
        currentGuesses = GameManager.instance.guesses;
        GameManager.instance.guessesChanged.AddListener(PlaySound);
    }
    
    void PlaySound(int newGuesses)
    {
        if (newGuesses >= currentGuesses)
        {
            AudioSource.PlayClipAtPoint(goldenGuess, transform.position);
        }
        else
        {
            AudioSource.PlayClipAtPoint(wrongGuess, transform.position);
        }

        currentGuesses = newGuesses;
    }
}
