using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgmControl : MonoBehaviour
{
    private AudioSource SoundManager;
    private AudioSource SeManager;

    public Slider volumeSlider_BGM;
    public Slider volumeSlider_SE;

    // Start is called before the first frame update
    void Start()
    {
        SoundManager = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        SeManager = GameObject.Find("SeManager").GetComponent<AudioSource>();

        // スライダーの初期値を設定
        volumeSlider_BGM.value = SoundManager.volume;
        volumeSlider_SE.value = SeManager.volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Slider_BGMChanged()
    {
        // スライダーの値に基づいて音量を変更
        SoundManager.volume = volumeSlider_BGM.value;
        
        Debug.Log("BGMの音量を" + SoundManager.volume + "に変更しました。");
    }

    public void Slider_SEChanged()
    {
        SeManager.volume = volumeSlider_SE.value;

        Debug.Log("SEの音量を" + SeManager.volume + "に変更しました。");
    }
}
