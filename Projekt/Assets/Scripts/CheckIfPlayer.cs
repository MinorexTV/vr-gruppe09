using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CheckIfPlayer : MonoBehaviour
{
    [SerializeField]
    private bool isPlayer = false;
    

    public void HitPlayer()
    {
        GameManager.instance.VRPlayerWon();
    }
    
    public void HitNPC()
    {
        GameManager.instance.ChangeGuesses(false);
    }
}
    