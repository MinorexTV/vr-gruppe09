using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyController : MonoBehaviour
{
    public TMP_Dropdown menu;
    void Awake()
    {
        menu.value = GameManager.instance.obstacles;
    }
    
    public void UpdateDifficulty()
    {
        GameManager.instance.ChangeObstacles(menu.value);
    }
}
