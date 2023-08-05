using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoGRabit : MonoBehaviour, IDangoInfo
{
    public string Name { get; } = "DangoG_rabit";
    //public Sprite Sprite { get; } = null;
    public string Color { get; } = "Green";
    public string Attribute { get; } = "Rabit";

    public int Point { get; set; } = 50;
    //public float Probability { get; set; } = 0.0f;
}
