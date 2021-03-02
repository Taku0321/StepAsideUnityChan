using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C3 : MonoBehaviour
{
    //MainCameraのオブジェクト
    private GameObject MainCamera;

    // Use this for initialization
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.MainCamera = GameObject.Find("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせて壁の位置を移動
        if (MainCamera.transform.position.z + 4 > this.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}