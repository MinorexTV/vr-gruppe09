using UnityEngine;

public class CoinSpawnController : MonoBehaviour
{
    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;
    public GameObject coin4;

    void Start()
    {
        coin1.SetActive(false);
        coin2.SetActive(false);
        coin3.SetActive(false);
        coin4.SetActive(false);
        Invoke("MakeObjectAppear", 10f);
    }

    void MakeObjectAppear()
    {
        coin1.SetActive(true);
        coin2.SetActive(true);
        coin3.SetActive(true);
        coin4.SetActive(true);
    }
}