using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;
    private int totalScore;

    private IDangoInfo dangoInfo;

    // Start is called before the first frame update
    void Start()
    {
        dangoInfo = GetComponent<IDangoInfo>();
    }

    //ダンゴに格納されているスコア情報を取得して加算する処理
    public void PointCalculator(int Point)
    {
        score += Point;
    }

    public void ScoreCalculator()
    {
        //if(dangoInfo.)
    }

}
