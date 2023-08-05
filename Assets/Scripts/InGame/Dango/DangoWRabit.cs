using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoWRabit : MonoBehaviour, IDangoInfo
{
    public string Name { get; } = "DangoW_rabit";
    //public Sprite Sprite { get; } = null;
    public string Color { get; } = "White";
    public string Attribute { get; } = "Rabit";

    public int Point { get; set; } = 50;
    //public float Probability { get; set; } = 0.0f;
}
