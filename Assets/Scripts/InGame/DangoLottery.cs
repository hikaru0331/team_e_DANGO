using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoLottery : MonoBehaviour
{
    //色の名前と重みを入れる辞書型変数
    public Dictionary<string, float> colorList;
    //色の抽選に使う重みの総和
    private float colorTotalWeight;

    //属性の名前と重みを入れる辞書型変数
    public Dictionary<string, float> attributeList;

    // Start is called before the first frame update
    void Start()
    {
        InitializeDicts();
        ColorWeightCalculator();
    }

    //各辞書の初期化
    private void InitializeDicts()
    {
        colorList = new Dictionary<string, float>
        {
            { "green", 1.0f },
            { "red", 1.0f },
            { "white", 1.0f }
        };

        attributeList = new Dictionary<string, float>
        {
            { "normal", 5.0f },
            { "poison", 2.0f },
            { "rabit", 3.0f }
        };
    }

    //色の抽選にかかる重みの総和計算
    public void ColorWeightCalculator()
    {
        // 重みの総和計算
        foreach (float value in colorList.Values)
        {
            colorTotalWeight += value;
        }
    }

    public string ChooseColor()
    {
        // 0～重みの総和の範囲の乱数値取得
        float randomPoint = Random.Range(0.0f, colorTotalWeight);

        // 乱数値が属する要素を先頭から順に選択
        var currentWeight = 0f;

        foreach (var value in colorList)
        {
            currentWeight += value.Value;

            // 乱数値が現在要素の範囲内かチェック
            if (randomPoint < currentWeight)
            {
                return value.Key;
            }
        }

        // 乱数値が重みの総和以上なら末尾要素とする
        return "colorList.Count - 1";
    }

    // Update is called once per frame
    private void Update()
    {
        // スペースキーを押している間、選択要素を出力し続ける
        if (Input.GetKey(KeyCode.Space))
        {
            var index = ChooseColor();
            Debug.Log($"抽選された要素 : {index}");
        }
    }
}
