using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenNPCController : MonoBehaviour
{
    private bool destroy;
    public void HitGoldenNPC()
    {
        destroy = GameManager.instance.guesses != 3; 
        GameManager.instance.ChangeGuesses(true);
        if (destroy)
        {
            Destroy(gameObject);
        }
    }
}