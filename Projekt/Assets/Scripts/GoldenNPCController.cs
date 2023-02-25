using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenNPCController : MonoBehaviour
{
    public void HitGoldenNPC()
    {
        if (GameManager.instance.guesses < 3)
        {
            GameManager.instance.ChangeGuesses(true);
            Destroy(gameObject);
        }
    }
}