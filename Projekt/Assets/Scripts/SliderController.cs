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
    public Slider vrslider2;
    public Slider vrslider3;
    public Slider vrslider4;

    public TextMeshProUGUI nonvrtextComp;
    public TextMeshProUGUI vrtextComp;
    public TextMeshProUGUI vrtextComp2;
    public TextMeshProUGUI vrtextComp3;
    public TextMeshProUGUI vrtextComp4;

    void Awake()
    {
        vrslider.value = GameManager.instance.npcs;
        vrslider2.value = GameManager.instance.npcs;
        vrslider3.value = GameManager.instance.npcs;
        vrslider4.value = GameManager.instance.npcs;
        nonvrslider.value = GameManager.instance.npcs;
    }

    public void UpdateNPCS()
    {
        GameManager.instance.ChangeNPCS(Mathf.RoundToInt(nonvrslider.value));
        nonvrtextComp.text = nonvrslider.value.ToString();
        vrtextComp.text = nonvrslider.value.ToString();
        vrtextComp2.text = nonvrslider.value.ToString();
        vrtextComp3.text = nonvrslider.value.ToString();
        vrtextComp4.text = nonvrslider.value.ToString();
        vrslider.value = nonvrslider.value;
        vrslider2.value = nonvrslider.value;
        vrslider3.value = nonvrslider.value;
        vrslider4.value = nonvrslider.value;
    }
}