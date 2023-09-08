using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RaccoonAnimation : MonoBehaviour
{
    //�^�k�L�I�u�W�F�N�g�̎擾
    private SpriteRenderer raccoonSprite;

    //�^�k�L�����_���S�̃I�u�W�F�N�g�̎擾
    [SerializeField] private GameObject dangoPositionObj;
    private SpriteRenderer positionSprite;
    //�_���S�����|�W�V�����̏�����Ԃ�����ϐ�
    private Transform positionInitialTransform;

    //�^�k�L�摜����������z��
    [SerializeField] private Sprite[] raccoonSprites;

    //�e�I�u�W�F�N�g��DangoEliminator�N���X�̎擾
    DangoEliminator dangoEliminator;

    //�H�����̃p�[�e�B�N��������z��
    [SerializeField] private GameObject[] eatParticles;

    private void Start()
    {
        //�^�k�L�I�u�W�F�N�g��Renderer�̎擾
        raccoonSprite = this.gameObject.GetComponent<SpriteRenderer>();

        //�^�k�L�����_���S�I�u�W�F�N�g��Renderer�擾
        positionSprite = dangoPositionObj.GetComponent<SpriteRenderer>();

        positionInitialTransform = dangoPositionObj.transform;

        //�e�I�u�W�F�N�g��DangoEliminator�N���X�̎擾
        dangoEliminator = transform.parent.gameObject.GetComponent<DangoEliminator>();
    }

    public void EatAnimation(Sprite dangoSprite, string dangoColor)
    {
        //�^�k�L�̎茳�ɂԂ����Ă����_���S�̉摜����
        positionSprite.sprite = dangoSprite;
        //�^�k�L�̉摜��H�����ɕύX
        raccoonSprite.sprite = raccoonSprites[1];

        //�^�k�L�̈ړ����ꎞ��~
        StartCoroutine(dangoEliminator.PauseTween(1.0f));

        GameObject instantiaterParticle = null;
        
        //�_���S�̐F�ɉ������p�[�e�B�N���̐���
        switch (dangoColor)
        {
            case "Green":
                instantiaterParticle = Instantiate(eatParticles[0], dangoPositionObj.transform);
                break;

            case "Red":
                instantiaterParticle = Instantiate(eatParticles[1], dangoPositionObj.transform);
                break;

            case "White":
                instantiaterParticle = Instantiate(eatParticles[2], dangoPositionObj.transform);
                break;
        }

        //�p�[�e�B�N�����P�b��ɔj��
        Destroy(instantiaterParticle, 1.0f);

        //�_���S�����񂾂񏬂������鏈��
        dangoPositionObj.transform.DOScale(new Vector2(0.0f, 0.0f), 1.0f);

        Invoke("dangoSpriteReset", 1.0f);
    }

    private void dangoSpriteReset()
    {
        //��Ɏ����Ă���_���S������
        positionSprite.sprite = null;
        //��Ɏ��_���S�̃I�u�W�F�N�g�̃T�C�Y�����ɖ߂�
        dangoPositionObj.transform
            .DOScale(new Vector2(0.4268948f, 0.4268948f), 0.0f);

        raccoonSprite.sprite = raccoonSprites[0];
    }

    public void poisonEatAnimation()
    {
        raccoonSprite.sprite = raccoonSprites[2];
    }

    public void raccoonSpriteReset()
    {
        raccoonSprite.sprite = raccoonSprites[0];
    }
}
