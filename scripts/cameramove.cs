using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{

    public float rotateSpeed = 0.5f;            //��]�̑���

    //�Ăяo�����Ɏ��s�����֐�
    void Start()
    {

    }


    //�P�ʎ��Ԃ��ƂɎ��s�����֐�
    void Update()
    {
        //rotateCamera�̌Ăяo��
        rotateCamera();
    }

    //�J��������]������֐�
    private void rotateCamera()
    {
        //Vector3��X,Y�����̉�]�̓x�������`
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, 0, 0);

        //Input.GetAxis("Mouse Y") * -rotateSpeed
        //transform.RotateAround()�����悤���ă��C���J��������]������
        this.transform.RotateAround(transform.position, Vector3.up, angle.x);
        //this.transform.RotateAround(transform.position, transform.right, angle.y);
    }
}
