using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreloaderController : MonoBehaviour
{
  private void Awake()
  {
    if (GameObject.Find("Game Manager") == null)
    {
      GameManager.Load();
    }
  }
}
