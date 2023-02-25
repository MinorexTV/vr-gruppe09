using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyController : MonoBehaviour
{
    public TMP_Dropdown nonvrmenu;
    public TMP_Dropdown vrmenu;
    public TMP_Dropdown vrmenu2;
    public TMP_Dropdown vrmenu3;
    public TMP_Dropdown vrmenu4;

    void Awake()
    {
        nonvrmenu.value = GameManager.instance.obstacles;
        vrmenu.value = GameManager.instance.obstacles;
        vrmenu2.value = GameManager.instance.obstacles;
        vrmenu3.value = GameManager.instance.obstacles;
        vrmenu4.value = GameManager.instance.obstacles;
    }

    public void UpdateDifficulty()
    {
        GameManager.instance.ChangeObstacles(nonvrmenu.value);
        vrmenu.value = nonvrmenu.value;
        vrmenu2.value = nonvrmenu.value;
        vrmenu3.value = nonvrmenu.value;
        vrmenu4.value = nonvrmenu.value;
    }
}