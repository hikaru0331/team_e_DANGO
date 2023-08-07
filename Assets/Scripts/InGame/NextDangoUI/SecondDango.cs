using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondDango : MonoBehaviour
{
    //���̃I�u�W�F�N�g��Image�R���|�[�l���g������ϐ�
    private Image secondImage;

    //DangoLottery�N���X�̎擾
    [SerializeField] private GameObject thirdDangoObj;
    private ThirdDango thirdDango;

    //���I���ʂ̃_���S�I�u�W�F�N�g������ϐ�
    [System.NonSerialized] public GameObject secondDango;

    // Start is called before the first frame update
    void Start()
    {
        secondImage = this.GetComponent<Image>();

        thirdDango = thirdDangoObj.GetComponent<ThirdDango>();

        ChooseSecondDango();
    }

    public GameObject ChooseSecondDango()
    {
        secondDango = thirdDango.ChooseThirdDango();
        SpriteRenderer secondRenderer = secondDango.GetComponent<SpriteRenderer>();

        secondImage.sprite = secondRenderer.sprite;

        return secondDango;
    }

}
