using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private float score;
    [System.NonSerialized] public float totalScore;

    private GoalSpriteManager goalSpriteManager;

    // Start is called before the first frame update
    void Start()
    {
        goalSpriteManager = GetComponent<GoalSpriteManager>();
    }

    //�_���S�Ɋi�[����Ă���X�R�A�����擾���ĉ��Z���鏈��
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

        Debug.Log(totalScore);

            yield return new WaitForSeconds(0.8f);

        score = 0;
    }

}
