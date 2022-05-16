using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{

    public float rotateSpeed = 0.5f;            //回転の速さ

    //呼び出し時に実行される関数
    void Start()
    {

    }


    //単位時間ごとに実行される関数
    void Update()
    {
        //rotateCameraの呼び出し
        rotateCamera();
    }

    //カメラを回転させる関数
    private void rotateCamera()
    {
        //Vector3でX,Y方向の回転の度合いを定義
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, 0, 0);

        //Input.GetAxis("Mouse Y") * -rotateSpeed
        //transform.RotateAround()をしようしてメインカメラを回転させる
        this.transform.RotateAround(transform.position, Vector3.up, angle.x);
        //this.transform.RotateAround(transform.position, transform.right, angle.y);
    }
}
