using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FilterGreen : Filter
{
    [SerializeField] private Sprite dangoSprite;
    [SerializeField] private Sprite dangoPoisonSprite;
    [SerializeField] private Sprite dangoRabitSprite;

    private IDangoInfo dangoInfo;
    private string dangoAttribute;

    private SpriteRenderer collisionRenderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        dangoInfo = collision.gameObject.GetComponent<IDangoInfo>();
        collisionRenderer = collision.gameObject.GetComponent<SpriteRenderer>();

        if (dangoInfo != null)
        {
            if (dangoInfo.Color != "Green")
            {
                dangoInfo.Color = "Green";

                dangoAttribute = dangoInfo.Attribute;
                ChangeDangoColor();
            }
        }
    }

    protected override void ChangeDangoColor()
    {
        switch (dangoAttribute)
        {
            case "Normal":
                dangoInfo.Name = "dangoG";
                dangoInfo.Sprite = dangoSprite;
                collisionRenderer.sprite = dangoInfo.Sprite;
                break;

            case "Poison":
                dangoInfo.Name = "dangoG_poison";
                dangoInfo.Sprite = dangoPoisonSprite;
                collisionRenderer.sprite = dangoInfo.Sprite;
                break;

            case "Rabit":
                dangoInfo.Name = "dangoG_rabit";
                dangoInfo.Sprite = dangoRabitSprite;
                collisionRenderer.sprite = dangoInfo.Sprite;
                break;
        }
    }
}
