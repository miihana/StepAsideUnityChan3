using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{

    //Unityちゃんのオブジェクト
    private GameObject unitychan;


    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの座標表示
        //Debug.Log("Unityちゃんのz座標" + this.unitychan.transform.position.z);
        //アイテムの座標表示
        //Debug.Log(tag +"アイテムのz座標" + this.transform.position.z);

        //画面外(Unityちゃんから6m以上後方に離れた)のアイテムを破棄
        if (this.unitychan.transform.position.z > this.transform.position.z+6.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
