using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoG : MonoBehaviour, IDangoInfo
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Sprite = spriteRenderer.sprite;
    }

    public string Name { get; } = "DangoG";
    public Sprite Sprite { get; set; } = null;
    public string Color { get; } = "Green";
    public string Attribute { get; } = "Normal";

    public int Point { get; set; } = 10;
    //public float Probability { get; set; } = 0.1f;
}
