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
    //　旋回するターゲット
    [SerializeField]
    private Transform target;
    //　現在の角度
    private float angle;

    //　回転するスピード
    [SerializeField]
    private float rotateSpeed = 1f;
    //　ターゲットからの距離
    [SerializeField]
    private Vector3 distanceFromTarget = new Vector3(0f, 3f, 4f);

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(target.position, Vector3.up, 100 * Time.deltaTime);
        //transform.Translate(0.01f,0,0);

        //　ユニットの位置 = ターゲットの位置 ＋ ターゲットから見たユニットの角度 ×　ターゲットからの距離
        transform.position = target.position + Quaternion.Euler(0, angle, 0) * distanceFromTarget;
        //　ユニット自身の角度 = ターゲットから見たユニットの方向の角度を計算しそれをユニットの角度に設定する
        transform.rotation = Quaternion.LookRotation(transform.position - new Vector3(target.position.x, transform.position.y, target.position.z), Vector3.up);
        //　ユニットの角度を変更
        angle += rotateSpeed * Time.deltaTime;
        //　角度を0～360度の間で繰り返す
        angle = Mathf.Repeat(angle, 360f);
    }
    */
}
