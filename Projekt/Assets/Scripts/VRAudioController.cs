using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRAudioController : MonoBehaviour
{
    private AudioClip wrongGuess;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.guessesChanged.AddListener(PlaySound);
        wrongGuess = GetComponent<AudioSource>().clip;
    }

    // Update is called once per frame
    void PlaySound(int g)
    {
        AudioSource.PlayClipAtPoint(wrongGuess, transform.position);
    }
}
