using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderController : MonoBehaviour
{
    public Slider slider;

    public TextMeshProUGUI textComp;

    void Awake()
    {
        //slider.value = GameManager.instance.npcs;
    }
    void Update()
    {
        textComp.text = slider.value.ToString();
        GameManager.instance.ChangeNPCS(Mathf.RoundToInt(slider.value));
    }
}
