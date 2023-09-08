using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI counttext;
    public SeController seController;
    public Image start;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CountdownCoroutine()
    {
        // 3秒カウントダウン
        seController.PlayCountdown();
        counttext.text = "3";   // 3を表示
        yield return new WaitForSeconds(1.0f);  // 1秒待つ
 
        seController.PlayCountdown();
		counttext.text = "2";
		yield return new WaitForSeconds(1.0f);
     
        seController.PlayCountdown();
		counttext.text = "1";
		yield return new WaitForSeconds(1.0f);
		
        seController.PlayStart();
		counttext.text = "";
        Debug.Log("カウントダウン終了");

        // カウントダウンが終わったらスタートを表示
        start.gameObject.SetActive(true);
    }
}
