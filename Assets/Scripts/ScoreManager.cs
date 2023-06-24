using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public Image[] images;
    Image1Replace a;
    Image2Replace b;
    Image3Replace c;
    bool[] flags;

    public TMP_Text ScoreText;
    public TMP_Text TotalScoreText;
    int score = 0;
    int totalScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var image in images)
    {
        image.enabled = false;
    }

        a = GetComponentInChildren<Image1Replace>();
        b = GetComponentInChildren<Image2Replace>();
        c = GetComponentInChildren<Image3Replace>();

        flags = new bool[3] { true, true, true };
    }

    // Update is called once per frame
    void Update()
    {
        // 団子完成後初期化
        if (!flags[2])
        {
            totalScore += score;
            TotalScoreText.text = string.Format("Score:{0}" , totalScore);
            foreach (var image in images)
            {
                image.enabled = false;
            }

            for (int i = 0; i < 3; i++)
            {
                flags[i] = true;
            }

            score = 0;
        }
    }

    private async void OnCollisionEnter2D(Collision2D other)
    {
        // 最初の衝突時の処理
        if (flags[0])
        {
            // image1に団子表示
            if (other.gameObject.name == "dangoG(Clone)" )
            {
                ShowDangoImage(0, 0);
            }
            else if (other.gameObject.name == "dangoR(Clone)" )
            {
                ShowDangoImage(0, 1);
            }
            else if (other.gameObject.name == "dangoW(Clone)" )
            {
                ShowDangoImage(0, 2);
            }
            else if (other.gameObject.name == "dangoG_rabit(Clone)" )
            {
                ShowDangoImage(0, 3);
            }
            else if (other.gameObject.name == "dangoR_rabit(Clone)" )
            {
                ShowDangoImage(0, 4);
            }
            else if (other.gameObject.name == "dangoW_rabit(Clone)" )
            {
                ShowDangoImage(0, 5);
            }

            flags[0] = false;
            ScoreText.text = string.Format("+{0}" , score);
        }
        // 2回目の衝突時の処理
        else if (flags[1])
        {
            // image2に団子表示
            if (other.gameObject.name == "dangoG(Clone)")
            {
                ShowDangoImage(1, 0);
            }
            else if (other.gameObject.name == "dangoR(Clone)")
            {
                ShowDangoImage(1, 1);
            }
            else if (other.gameObject.name == "dangoW(Clone)")
            {
                ShowDangoImage(1, 2);
            }
            else if (other.gameObject.name == "dangoG_rabit(Clone)")
            {
                ShowDangoImage(1, 3);
            }
            else if (other.gameObject.name == "dangoR_rabit(Clone)" )
            {
                ShowDangoImage(1, 4);
            }
            else if (other.gameObject.name == "dangoW_rabit(Clone)" )
            {
                ShowDangoImage(1, 5);
            }

            flags[1] = false;
            ScoreText.text = string.Format("+{0}" , score);
        }
        // 3回目の衝突時の処理
        else if (flags[2])
        {
            // image3に団子表示
            if (other.gameObject.name == "dangoG(Clone)")
            {
                ShowDangoImage(2, 0);
            }
            else if (other.gameObject.name == "dangoR(Clone)")
            {
                ShowDangoImage(2, 1);
            }
            else if (other.gameObject.name == "dangoW(Clone)")
            {
                ShowDangoImage(2, 2);
            }
            else if (other.gameObject.name == "dangoG_rabit(Clone)")
            {
                ShowDangoImage(2, 3);
            }
            else if (other.gameObject.name == "dangoR_rabit(Clone)" )
            {
                ShowDangoImage(2, 4);
            }
            else if (other.gameObject.name == "dangoW_rabit(Clone)" )
            {
                ShowDangoImage(2, 5);
            }
            
            flags[2] = false;
            ScoreText.text = string.Format("+{0}" , score);
        }
        
        Destroy(other.gameObject);
        Debug.Log("Goal!!");
    }

    private void ShowDangoImage(int index, int imageIndex)
    {
        images[index].enabled = true;

        switch (index)
        {
            case 0:
                a.SetImage(imageIndex);
                break;
            case 1:
                b.SetImage(imageIndex);
                break;
            case 2:
                c.SetImage(imageIndex);
                break;
        }
        
        switch (imageIndex)
        {
            case 0:
            case 1:
            case 2:
                score += 10;
                break;
            case 3:
            case 4:
            case 5:
                score += 50;
                break;
        }
    }
}
