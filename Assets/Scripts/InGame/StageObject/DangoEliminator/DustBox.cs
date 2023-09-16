using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustBox : MonoBehaviour
{
    private SoundManager soundManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        soundManager = SoundManager.Instance;
        soundManager.seManager.PlayOneShot(soundManager.dustBox);

        //�Ԃ����Ă����I�u�W�F�N�g��j��
        Destroy(collision.gameObject);
    }
}
