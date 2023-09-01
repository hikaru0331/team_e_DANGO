using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickManager : MonoBehaviour
{
    public AudioSource soundEffectAudioSource;  // 効果音のAudioSource

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        soundEffectAudioSource.Play(); // ボタンクリック音を再生
    }
}
