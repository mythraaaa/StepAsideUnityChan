using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
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
        //座標取得
        Debug.Log("unitychan Z: " + (unitychan.transform.position.z - transform.position.z));

        //条件文で呼び出して破壊
        if (unitychan.transform.position.z - this.transform.position.z > 6f)
        {
            Destroy(this.gameObject);
        }
    }

}