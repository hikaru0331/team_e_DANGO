using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaccoonController : MonoBehaviour
{
    private FeverStarter feverStarter;

    private void Start()
    {
        feverStarter = this.gameObject.GetComponent<FeverStarter>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�C���^�[�t�F�[�X�Ƃ��ėp�ӂ����N���X�̃C���X�^���X��
        //�_���S�ɒ��ڃA�^�b�`����Ă��Ȃ����A�A�^�b�`����Ă���N���X(DangoG�Ȃ�)�̐e�N���X�̂��ߎ擾�\
        if (collision.gameObject.TryGetComponent<IDangoInfo>(out var dangoInfo))
        {
            feverStarter.DangoEat(dangoInfo.Attribute);

            Destroy(collision.gameObject);
        }
    }
}
