using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realworldread : MonoBehaviour
{
    WebCamTexture webCamTexture;
    // Start is called before the first frame update
    void Start()
    {
        // 画面の向きを固定（端末の向きに応じて回転させない設定）
        Screen.orientation = ScreenOrientation.Portrait;
        // 端末のカメラを読み込み
        WebCamDevice[] devices = WebCamTexture.devices;
        // テクスチャとして背面カメラを設定(devices[0]で背面、devices[1]で前面）
        WebCamTexture webCamTexture = new WebCamTexture(devices[0].name);
        // このScriptを付与したオブジェクトにテクスチャを反映
        GetComponent<Renderer>().material.mainTexture = webCamTexture;
        // カメラを起動
        webCamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
