using UnityEngine;
using System.Collections;

public class C : MonoBehaviour
{
    //木を入れる
    public GameObject Broadleaf;
    //スタート地点
    private int startPos = -10;
    //ゴール地点
    private int goalPos = 400;

    // Use this for initialization
    void Start()
    {
        //アイテムを置くZ座標のオフセットをランダムに設定
        int offsetZ = Random.Range(-2, 5);
        //一定の距離ごとにアイテムを生成
        for (int i = startPos; i < goalPos; i+=7)
        {
            //木を生成
            GameObject Broad = Instantiate(Broadleaf);
            Broad.transform.position = new Vector3(7, Broad.transform.position.y, i + offsetZ);
        }

        //一定の距離ごとにアイテムを生成
        for (int y = startPos; y < goalPos; y += 7)
        {
            //木を生成
            GameObject Broad = Instantiate(Broadleaf);
            Broad.transform.position = new Vector3(-7, Broad.transform.position.y, y + offsetZ);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}