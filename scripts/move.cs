using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float speed = 1.5f;

    private void Update()
    {
        transform.position += transform.forward*speed*Time.deltaTime;
    }


    /*
    //�@���񂷂�^�[�Q�b�g
    [SerializeField]
    private Transform target;
    //�@���݂̊p�x
    private float angle;

    //�@��]����X�s�[�h
    [SerializeField]
    private float rotateSpeed = 1f;
    //�@�^�[�Q�b�g����̋���
    [SerializeField]
    private Vector3 distanceFromTarget = new Vector3(0f, 3f, 4f);

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(target.position, Vector3.up, 100 * Time.deltaTime);
        //transform.Translate(0.01f,0,0);

        //�@���j�b�g�̈ʒu = �^�[�Q�b�g�̈ʒu �{ �^�[�Q�b�g���猩�����j�b�g�̊p�x �~�@�^�[�Q�b�g����̋���
        transform.position = target.position + Quaternion.Euler(0, angle, 0) * distanceFromTarget;
        //�@���j�b�g���g�̊p�x = �^�[�Q�b�g���猩�����j�b�g�̕����̊p�x���v�Z����������j�b�g�̊p�x�ɐݒ肷��
        transform.rotation = Quaternion.LookRotation(transform.position - new Vector3(target.position.x, transform.position.y, target.position.z), Vector3.up);
        //�@���j�b�g�̊p�x��ύX
        angle += rotateSpeed * Time.deltaTime;
        //�@�p�x��0�`360�x�̊ԂŌJ��Ԃ�
        angle = Mathf.Repeat(angle, 360f);
    }
    */
}
