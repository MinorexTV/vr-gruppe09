using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderController : MonoBehaviour
{
    public Slider nonvrslider;
    public Slider vrslider;

    public TextMeshProUGUI nonvrtextComp;
    public TextMeshProUGUI vrtextComp;

    void Awake()
    {
        vrslider.value = GameManager.instance.npcs;
        nonvrslider.value = GameManager.instance.npcs;
    }
    public void UpdateNPCS()
    {
        GameManager.instance.ChangeNPCS(Mathf.RoundToInt(nonvrslider.value));
        nonvrtextComp.text = nonvrslider.value.ToString();
        vrtextComp.text = nonvrslider.value.ToString();
        vrslider.value = nonvrslider.value;
    }
}
