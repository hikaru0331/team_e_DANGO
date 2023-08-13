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

    //ƒ_ƒ“ƒS‚ÉŠi”[‚³‚ê‚Ä‚¢‚éƒXƒRƒAî•ñ‚ğæ“¾‚µ‚Ä‰ÁZ‚·‚éˆ—
    public void PointCalculator(int Point)
    {
        score += Point;
    }

    public void ScoreCalculator()
    {
        //if(dangoInfo.)
    }

}
