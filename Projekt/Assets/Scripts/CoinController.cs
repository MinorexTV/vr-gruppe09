using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private GameObject coin1;
    [SerializeField] private GameObject coin2;
    [SerializeField] private GameObject coin3;
    
    [SerializeField] private GameObject ecoin1;
    [SerializeField] private GameObject ecoin2;
    [SerializeField] private GameObject ecoin3;

    private void Start()
    {
        coin1.SetActive(false);
        coin2.SetActive(false);
        coin3.SetActive(false);
        
        ecoin1.SetActive(true);
        ecoin2.SetActive(true);
        ecoin3.SetActive(true);
        GameManager.instance.nonvrpointsChanged.AddListener(UpdateCoins);
    }

    void UpdateCoins(int value)
    {
        if (value == 3)
        {
            coin1.SetActive(true);
            coin2.SetActive(true);
            coin3.SetActive(true);
            
            ecoin1.SetActive(false);
            ecoin2.SetActive(false);
            ecoin3.SetActive(false);
        }
        else if (value == 2)
        {
            coin1.SetActive(false);
            coin2.SetActive(true);
            coin3.SetActive(true);
            
            ecoin1.SetActive(true);
            ecoin2.SetActive(false);
            ecoin3.SetActive(false);
        }
        else if (value == 1)
        {
            coin1.SetActive(false);
            coin2.SetActive(false);
            coin3.SetActive(true);
            
            ecoin1.SetActive(true);
            ecoin2.SetActive(true);
            ecoin3.SetActive(false);
        }
    }
}