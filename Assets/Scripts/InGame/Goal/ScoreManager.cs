using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private float score;
    [System.NonSerialized] public float totalScore;

    [SerializeField] private TMP_Text scoreText;

    private GoalSpriteManager goalSpriteManager;

    // Start is called before the first frame update
    void Start()
    {
        goalSpriteManager = GetComponent<GoalSpriteManager>();

        scoreText.text = "Score: " + totalScore.ToString();
    }

    //ƒ_ƒ“ƒS‚ÉŠi”[‚³‚ê‚Ä‚¢‚éƒXƒRƒAî•ñ‚ğæ“¾‚µ‚Ä‰ÁZ‚·‚éˆ—
    public void PointCalculator(int Point)
    {
        score += Point;
    }

    public IEnumerator ScoreCalculator()
    {
        if (goalSpriteManager.rightColor == goalSpriteManager.centerColor &&
            goalSpriteManager.centerColor == goalSpriteManager.leftColor)
        {
            totalScore += score * 1.5f;
        }
        else if (goalSpriteManager.rightColor != goalSpriteManager.centerColor &&
            goalSpriteManager.centerColor != goalSpriteManager.leftColor &&
            goalSpriteManager.leftColor != goalSpriteManager.rightColor)
        {
            totalScore += score * 2.0f;
        }
        else
        {
            totalScore += score;            
        }

        yield return new WaitForSeconds(0.8f);

        scoreText.text = "Score: " + totalScore.ToString();

        score = 0;
    }

}
