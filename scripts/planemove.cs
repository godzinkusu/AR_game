using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planemove : MonoBehaviour
{

    public GameObject post;

    public float speed = 3.8f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= transform.right*speed*Time.deltaTime;

        this.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);

        if(this.transform.position.x >= -80 && this.transform.localScale.x >=120)
        {
            post.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
