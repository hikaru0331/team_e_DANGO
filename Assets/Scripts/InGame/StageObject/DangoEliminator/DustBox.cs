using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustBox : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�Ԃ����Ă����I�u�W�F�N�g��j��
        Destroy(collision.gameObject);
    }
}
