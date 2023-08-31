using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustBox : MonoBehaviour
{  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ぶつかってきたオブジェクトを破壊
        Destroy(collision.gameObject);
    }
}
