using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realworldread : MonoBehaviour
{
    WebCamTexture webCamTexture;
    // Start is called before the first frame update
    void Start()
    {
        // ��ʂ̌������Œ�i�[���̌����ɉ����ĉ�]�����Ȃ��ݒ�j
        Screen.orientation = ScreenOrientation.Portrait;
        // �[���̃J������ǂݍ���
        WebCamDevice[] devices = WebCamTexture.devices;
        // �e�N�X�`���Ƃ��Ĕw�ʃJ������ݒ�(devices[0]�Ŕw�ʁAdevices[1]�őO�ʁj
        WebCamTexture webCamTexture = new WebCamTexture(devices[0].name);
        // ����Script��t�^�����I�u�W�F�N�g�Ƀe�N�X�`���𔽉f
        GetComponent<Renderer>().material.mainTexture = webCamTexture;
        // �J�������N��
        webCamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
