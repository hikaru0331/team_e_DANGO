using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoGPoison : MonoBehaviour, IDangoInfo
{
    public string Name { get; } = "DangoG_poison";
    //public Sprite Sprite { get; } = null;
    public string Color { get; } = "Green";
    public string Attribute { get; } = "Poison";

    public int Point { get; set; } = 0;
    //public float Probability { get; set; } = 0.0f;
}
