using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyController : MonoBehaviour
{
    public TMP_Dropdown nonvrmenu;
    public TMP_Dropdown vrmenu;
    void Awake()
    {
        nonvrmenu.value = GameManager.instance.obstacles;
        vrmenu.value = GameManager.instance.obstacles;
    }
    
    public void UpdateDifficulty()
    {
        GameManager.instance.ChangeObstacles(nonvrmenu.value);
        vrmenu.value = nonvrmenu.value;
    }
}
