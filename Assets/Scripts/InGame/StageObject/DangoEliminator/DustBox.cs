using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustBox : MonoBehaviour
{  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�Ԃ����Ă����I�u�W�F�N�g��j��
        Destroy(collision.gameObject);
    }
}
