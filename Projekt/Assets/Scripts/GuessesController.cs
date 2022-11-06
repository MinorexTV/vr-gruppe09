using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GuessesController : MonoBehaviour
{
    TMP_Text textComp;
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
    }
}
