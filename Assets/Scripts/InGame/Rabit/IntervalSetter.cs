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

        //intarval��2�b����1�b�܂ŒZ�����鏈��
        if (timer > 10.0f && DangoGenerator.dangoInterval >= 1.0f)
        {
            DangoGenerator.dangoInterval -= 0.1f;
            timer = 0;
        }
        
        //interval��1�b����0.5�b�܂ŒZ�����鏈��
        if (totalTimer > 180.0f && timer > 10.0f && DangoGenerator.dangoInterval >= 0.5f)
        {
            DangoGenerator.dangoInterval -= 0.1f;
            timer = 0;
        }
    }
}
