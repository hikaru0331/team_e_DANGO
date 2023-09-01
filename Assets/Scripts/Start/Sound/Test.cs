using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {
public AudioSource audioSource;

public AudioClip decide;
public AudioClip sound2;
public AudioClip sound3;
public AudioClip sound4;

public Button start;
public Button option;

    void Start () {
        //Componentを取得
        audioSource = GameObject.Find("BgmManager").GetComponent<AudioSource>();
        start = GameObject.Find("ButtonGame").GetComponent<Button>();
        option = GameObject.Find("ButtonOption").GetComponent<Button>();

        start.onClick.AddListener(OnClickButton);
        option.onClick.AddListener(OnClickButton);
    }

    void OnClickButton() {
        audioSource.PlayOneShot(decide);
    }

}