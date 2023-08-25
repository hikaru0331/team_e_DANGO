using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;
using DG.Tweening;

public class ScoreDisplay : MonoBehaviour
{
    
    public GameObject scoreText;
    public float scaleDuration = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async void ShowScore (float Score)
    {
        await Task.Delay(1000); // 1秒待つ
        
        TextMeshProUGUI scoreText = this.scoreText.GetComponent<TextMeshProUGUI>();
        scoreText.text = "スコア: " + Score.ToString();
        //scoreText.transform.DOMove(0, 150, 0, scaleDuration);
    }
}
