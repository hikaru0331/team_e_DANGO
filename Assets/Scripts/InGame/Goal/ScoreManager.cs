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

    //É_ÉìÉSÇ…äiî[Ç≥ÇÍÇƒÇ¢ÇÈÉXÉRÉAèÓïÒÇéÊìæÇµÇƒâ¡éZÇ∑ÇÈèàóù
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
            scoreText.text = "Score: " + totalScore.ToString();
        }
        else if (goalSpriteManager.rightColor != goalSpriteManager.centerColor &&
            goalSpriteManager.centerColor != goalSpriteManager.leftColor &&
            goalSpriteManager.leftColor != goalSpriteManager.rightColor)
        {
            totalScore += score * 2.0f;
            scoreText.text = "Score: " + totalScore.ToString();
        }
        else
        {
            totalScore += score;
            scoreText.text = "Score: " + totalScore.ToString();
        }

        Debug.Log(totalScore);

            yield return new WaitForSeconds(0.8f);

        score = 0;
    }

}
