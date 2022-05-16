using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Ç±Ç±ïKê{
using UnityEngine.Rendering.PostProcessing;

public class WebCameraController : MonoBehaviour
{
    public int Width = 1920;
    public int Height = 1080;
    public int FPS = 30;

    public GameObject maingame;
    public GameObject subgame;
    public GameObject appear;

    private Image appearimage;

    public GameObject post;

    private WebCamTexture webcamTexture;

    public Color32[] color32;

    private float time = 0;

    private bool good = true;


    void Start()
    {
        

        WebCamDevice[] devices = WebCamTexture.devices;

        //appearimage = appear.GetComponent<Image>();

        //appearimage.fillAmount = 0;

        // display all cameras
        for (var i = 0; i < devices.Length; i++)
        {
            Debug.Log(devices[i].name);
        }


        webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
        subgame.GetComponent<Renderer>().material.mainTexture = webcamTexture;
        maingame.GetComponent<Renderer>().material.mainTexture = webcamTexture;
        //appearimage.material.mainTexture = webcamTexture;
        webcamTexture.Play();

        /*
        color32 = webcamTexture.GetPixels32();


        Texture2D texture = new Texture2D(webcamTexture.width, webcamTexture.height);
        texture.SetPixels32(color32);
        texture.Apply();

        appearimage.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);

        */


        /*
         * 
         *         if (devices.Length > 0)
        {
            WebCamTexture mywebcamTexture = new WebCamTexture(devices[0].name,Width,Height,FPS);

            maingame.GetComponent<MeshRenderer>().material.mainTexture = mywebcamTexture;
            subgame.GetComponent<MeshRenderer>().material.mainTexture = mywebcamTexture;
            mywebcamTexture.Play();
        }

        */
    }

    /*

    void Update()
    {
        if (good)
        {
            time += Time.deltaTime;
        }

        if (time>=0.5f)
        {
            Debug.Log("ok");
            color32 = webcamTexture.GetPixels32();


            Texture2D texture = new Texture2D(webcamTexture.width, webcamTexture.height);
            texture.SetPixels32(color32);
            texture.Apply();

            appearimage.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);

            time = 0;
        }


        appearimage.fillAmount += 0.0005f;

        if(appearimage.fillAmount >= 0.99f)
        {
            post.SetActive(false);
            Destroy(appear);
            good = false;

        }
    }
    */
}