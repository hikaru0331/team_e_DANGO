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

private static bool isLoad = false; // 自身がすでにロードされているかを判定するフラグ
    
    private void Awake() {
        if (isLoad) { // すでにロードされていたら
            Destroy(this.gameObject); // 自分自身を破棄して終了
            return;
        }
        isLoad = true; // ロードされていなかったら、フラグをロード済みに設定する
		DontDestroyOnLoad(gameObject);
	}

    void Start () {
        //Componentを取得
        audioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        start = GameObject.Find("ButtonGame").GetComponent<Button>();
        option = GameObject.Find("ButtonOption").GetComponent<Button>();

        start.onClick.AddListener(OnClickButton);
        option.onClick.AddListener(OnClickButton);
    }

    void OnClickButton() {
        audioSource.PlayOneShot(decide);
    }

}