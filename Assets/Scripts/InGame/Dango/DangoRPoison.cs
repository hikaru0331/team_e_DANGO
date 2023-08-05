using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoRPoison : MonoBehaviour, IDangoInfo
{
    public string Name { get; } = "DangoR_poison";
    //public Sprite Sprite { get; } = null;
    public string Color { get; } = "Red";
    public string Attribute { get; } = "Poison";

    public int Point { get; set; } = 0;
    //public float Probability { get; set; } = 0.0f;
}
