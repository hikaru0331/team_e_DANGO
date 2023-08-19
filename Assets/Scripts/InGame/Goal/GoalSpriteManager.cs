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

    [System.NonSerialized] public string rightColor;
    [System.NonSerialized] public string centerColor;
    [System.NonSerialized] public string leftColor;

    private ScoreManager scoreManager;
    private GameOverManager gameOverManager;

    // Start is called before the first frame update
    void Start()
    {
        rightRenderer = goalRight.GetComponent<SpriteRenderer>();
        centerRenderer = goalCenter.GetComponent<SpriteRenderer>();
        leftRenderer = goalLeft.GetComponent<SpriteRenderer>();

        scoreManager = this.gameObject.GetComponent<ScoreManager>();
        gameOverManager = this.gameObject.GetComponent<GameOverManager>();

        RemoveSprite();
    }

    private void RemoveSprite()
    {
        rightRenderer.sprite = null;
        centerRenderer.sprite = null;
        leftRenderer.sprite = null;
    }

    public void SpriteChanger(Sprite dangoSprite, string dangoColor)
    {
        if (rightRenderer.sprite == null)
        {
            rightRenderer.sprite = dangoSprite;
            rightColor = dangoColor;
        }
        else if (centerRenderer.sprite == null)
        {
            centerRenderer.sprite = dangoSprite;
            centerColor = dangoColor;
        }
        else if (leftRenderer.sprite == null)
        {
            leftRenderer.sprite = dangoSprite;
            leftColor = dangoColor;

            StartCoroutine(scoreManager.ScoreCalculator());

            Invoke("RemoveSprite", 0.8f);
            gameOverManager.Invoke("PoisonChecker", 0.8f);
        }
    }

}
