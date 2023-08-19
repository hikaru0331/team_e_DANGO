using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FilterGreen : Filter
{
    //�_���S�̊e�N���X��Sprite�v���p�e�B�ɓ���邽�߂̏�������ϐ�
    [SerializeField] private Sprite dangoSprite;
    [SerializeField] private Sprite dangoPoisonSprite;
    [SerializeField] private Sprite dangoRabitSprite;

    //�_���S�̃C���^�[�t�F�[�X������ϐ�
    private IDangoInfo dangoInfo;
    //�_���S�̊e�N���X����擾����Attribute�v���p�e�B������ϐ�
    private string dangoAttribute;

    //�G��Ă����I�u�W�F�N�g��SpriteRenderer�R���|�[�l���g������ϐ�
    private SpriteRenderer collisionRenderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�G��Ă����_���S�̃X�N���v�g���擾
        dangoInfo = collision.gameObject.GetComponent<IDangoInfo>();
        //�G��Ă����_���S��SpriteRenderer���擾
        collisionRenderer = collision.gameObject.GetComponent<SpriteRenderer>();

        if (dangoInfo != null)
        {
            if (dangoInfo.Color != "Green")
            {
                //�G��Ă����_���S��Color�v���p�e�B��΂ɕύX
                dangoInfo.Color = "Green";

                //�G��Ă����_���S��Attribute�v���p�e�B����
                dangoAttribute = dangoInfo.Attribute;
                ChangeDangoColor();
            }
        }
    }

    protected override void ChangeDangoColor()
    {
        //�G��Ă����_���S�̑����ɉ����ďꍇ����
        switch (dangoAttribute)
        {
            case "Normal":
                dangoInfo.Name = "dangoG";
                dangoInfo.Sprite = dangoSprite;
                collisionRenderer.sprite = dangoInfo.Sprite;
                break;

            case "Poison":
                dangoInfo.Name = "dangoG_poison";
                dangoInfo.Sprite = dangoPoisonSprite;
                collisionRenderer.sprite = dangoInfo.Sprite;
                break;

            case "Rabit":
                dangoInfo.Name = "dangoG_rabit";
                dangoInfo.Sprite = dangoRabitSprite;
                collisionRenderer.sprite = dangoInfo.Sprite;
                break;
        }
    }
}
