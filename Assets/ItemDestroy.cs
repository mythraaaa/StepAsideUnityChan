using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //���W�擾
        Debug.Log("unitychan Z: " + (unitychan.transform.position.z - transform.position.z));

        //�������ŌĂяo���Ĕj��
        if (unitychan.transform.position.z - this.transform.position.z > 6f)
        {
            Destroy(this.gameObject);
        }
    }

}