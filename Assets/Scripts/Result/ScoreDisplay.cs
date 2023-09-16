using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class ScoreDisplay : MonoBehaviour
{
    
    public GameObject scoreText;
    public float scaleDuration = 0.5f;
    public ButtonDisplay ButtonDisplay; // ボタン表示用のスクリプト

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowScore (float Score)
    {
        TextMeshProUGUI scoreText = this.scoreText.GetComponent<TextMeshProUGUI>();
        scoreText.text = "スコア: " + Score.ToString();

        ButtonDisplay.ShowButtons();
    }
}
