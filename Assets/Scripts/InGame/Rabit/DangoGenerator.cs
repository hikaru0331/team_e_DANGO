using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoGenerator : MonoBehaviour
{
    //�c�q�����ꏊ�̃Q�[���I�u�W�F�N�g������ϐ�
    public GameObject generatePosition;

    //�c�q�����ɂ������ϐ�
    [System.NonSerialized] public GameObject dango;
    private float timer;
    [System.NonSerialized] public static float dangoInterval = 2.0f;
    private GameObject generatedDango;

    //RabitAnimator�N���X�̎擾
    RabitAnimator rabitAnimator;

    //NextDango�N���X�̎擾
    [SerializeField] private GameObject nextDangoObj;
    private NextDango nextDango;

    private SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        rabitAnimator = GetComponent<RabitAnimator>();

        nextDango = nextDangoObj.GetComponent<NextDango>();

        soundManager = SoundManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= dangoInterval)
        {
            timer = 0;

            //RabitAnimator�N���X�ɂ���SpriteRenderer�R���|�[�l���g�ɃA�N�Z�X
            //�X�v���C�g��RabitAnimator�N���X��shotSprite�ɕύX
            rabitAnimator.rabitSprite.sprite = rabitAnimator.shotSprite;

            //NextDango�N���X��public�ϐ�nextDango����
            dango = nextDango.nextDango;

            nextDango.ChooseNextDango();

            IDangoInfo dangoInfo = dango.GetComponent<IDangoInfo>();

            switch(dangoInfo.Attribute)
            {
                case "Normal":
                    soundManager.seManager.PlayOneShot(soundManager.generateMiddle);
                    break;

                case "Rabit":
                    soundManager.seManager.PlayOneShot(soundManager.generateHigh);
                    break;

                case "Poison":
                    soundManager.seManager.PlayOneShot(soundManager.generateLow);
                    break;
            }
                
            //�_���S����
            generatedDango = Instantiate(dango, generatePosition.gameObject.transform.position, Quaternion.identity);

            //�X�v���C�g��RabitAnimator�N���X��idleSprite�ɖ߂��������Ăяo��
            rabitAnimator.Invoke("SpriteResetter", 0.2f);
        }
    }
}
