using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreboardController : MonoBehaviour
{
    public TMP_Text vrscore;
    public TMP_Text nonvrscore;
    
    void Awake()
    {
        vrscore.text = "vr: " + GameManager.instance.vrwins;
        nonvrscore.text = "nonvr: " + GameManager.instance.nonvrwins;
    }
}
