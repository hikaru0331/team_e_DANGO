using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaccoonController : MonoBehaviour
{
    private FeverStarter feverStarter;
    private RaccoonAnimation raccoonAnimation;

    private SoundManager soundManager;

    private void Start()
    {
        feverStarter = this.gameObject.GetComponent<FeverStarter>();
        raccoonAnimation = this.gameObject.GetComponent<RaccoonAnimation>();

        soundManager = SoundManager.Instance;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�C���^�[�t�F�[�X�Ƃ��ėp�ӂ����N���X�̃C���X�^���X��
        //�_���S�ɒ��ڃA�^�b�`����Ă��Ȃ����A�A�^�b�`����Ă���N���X(DangoG�Ȃ�)�̐e�N���X�̂��ߎ擾�\
        if (collision.gameObject.TryGetComponent<IDangoInfo>(out var dangoInfo))
        {
            soundManager.seManager.PlayOneShot(soundManager.eat);

            StartCoroutine(feverStarter.DangoEat(dangoInfo.Attribute));

            raccoonAnimation.EatAnimation(dangoInfo.Sprite, dangoInfo.Color);

            Destroy(collision.gameObject);
        }
    }
}
