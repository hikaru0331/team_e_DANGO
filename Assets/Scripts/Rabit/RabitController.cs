using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabitController : MonoBehaviour
{
    //���̃I�u�W�F�N�g������ϐ��ƈړ����x�̕ϐ�
    public GameObject rabit;
    public float moveSpeed;
 
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 8)
        {
            rabit.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -8)
        {
            rabit.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
    }
}
