using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private GameObject coin1;
    [SerializeField] private GameObject coin2;
    [SerializeField] private GameObject coin3;

    private void Start()
    {
        coin1.SetActive(false);
        coin2.SetActive(false);
        coin3.SetActive(false);
        GameManager.instance.nonvrpointsChanged.AddListener(UpdateCoins);
    }

    void UpdateCoins(int value)
    {
        if (value == 3)
        {
            coin1.SetActive(true);
            coin2.SetActive(true);
            coin3.SetActive(true);
        }
        else if (value == 2)
        {
            coin1.SetActive(false);
            coin2.SetActive(true);
            coin3.SetActive(true);
        }
        else if (value == 1)
        {
            coin1.SetActive(false);
            coin2.SetActive(false);
            coin3.SetActive(true);
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