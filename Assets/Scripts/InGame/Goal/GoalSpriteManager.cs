using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSpriteManager : MonoBehaviour
{
    [SerializeField] private GameObject goalRight;
    [SerializeField] private GameObject goalCenter;
    [SerializeField] private GameObject goalLeft;

    private SpriteRenderer rightRenderer;
    private SpriteRenderer centerRenderer;
    private SpriteRenderer leftRenderer;

    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        rightRenderer = goalRight.GetComponent<SpriteRenderer>();
        centerRenderer = goalCenter.GetComponent<SpriteRenderer>();
        leftRenderer = goalLeft.GetComponent<SpriteRenderer>();

        scoreManager = this.gameObject.GetComponent<ScoreManager>();

        RemoveSprite();
    }

    public void SpriteChanger(Sprite dangoSprite)
    {
        if(rightRenderer.sprite == null)
            rightRenderer.sprite = dangoSprite;

        else if(centerRenderer.sprite == null)
            centerRenderer.sprite = dangoSprite;

        else if (leftRenderer.sprite == null)
        {
            leftRenderer.sprite = dangoSprite;

            scoreManager.ScoreCalculator();

            Invoke("RemoveSprite", 0.8f);
        }
    }

    private void RemoveSprite()
    {
        rightRenderer.sprite = null;
        centerRenderer.sprite = null;
        leftRenderer.sprite = null;
    }

}
