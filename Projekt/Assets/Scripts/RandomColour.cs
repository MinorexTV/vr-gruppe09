using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class RandomColour : MonoBehaviour
{
    public List<Color> TintColors;

    // Start is called before the first frame update
    void Start()
    {
        if (TintColors.Count > 0)
        {
            Color c = TintColors[Random.Range(0, TintColors.Count)];
            GetComponent<Renderer>().material.color = c;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}