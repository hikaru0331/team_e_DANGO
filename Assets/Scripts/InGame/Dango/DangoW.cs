using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoW : MonoBehaviour, IDangoInfo
{
    public string Name { get; } = "DangoW";
    //public Sprite Sprite { get; } = null;
    public string Color { get; } = "White";
    public string Attribute { get; } = "Normal";

    public int Point { get; set; } = 10;
    //public float Probability { get; set; } = 0.0f;
}
