using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoG : MonoBehaviour, IDangoInfo
{
    public string Name { get; } = "DangoG";
    //public Sprite Sprite { get; } = null;
    public string Color { get; } = "Green";
    public string Attribute { get; } = "Normal";

    public int Point { get; set; } = 10;
    //public float Probability { get; set; } = 0.1f;
}
