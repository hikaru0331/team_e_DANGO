using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntervalSetter : MonoBehaviour
{
    private float timer;
    private float totalTimer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        totalTimer += Time.deltaTime;

        //intarvalを2秒から1秒まで短くする処理
        if (timer > 10.0f && DangoGenerator.dangoInterval >= 1.0f)
        {
            DangoGenerator.dangoInterval -= 0.1f;
            timer = 0;
        }
        
        //intervalを1秒から0.5秒まで短くする処理
        if (totalTimer > 180.0f && timer > 10.0f && DangoGenerator.dangoInterval >= 0.5f)
        {
            DangoGenerator.dangoInterval -= 0.1f;
            timer = 0;
        }
    }
}
