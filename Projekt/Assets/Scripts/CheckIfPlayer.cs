using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CheckIfPlayer : MonoBehaviour
{
    [SerializeField] private bool isPlayer = false;


    public void HitPlayer()
    {
        if (Mathf.RoundToInt(Time.timeScale) == 1)
        {
            GameManager.instance.VRPlayerWon();
        }
    }

    public void HitNPC()
    {
        if (Mathf.RoundToInt(Time.timeScale) == 1)
        {
            GameManager.instance.ChangeGuesses(false);
            Destroy(gameObject);
        }
    }
}