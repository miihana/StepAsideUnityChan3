using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
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
        //Unity�����̍��W�\��
        //Debug.Log("Unity������z���W" + this.unitychan.transform.position.z);
        //�A�C�e���̍��W�\��
        //Debug.Log(tag +"�A�C�e����z���W" + this.transform.position.z);

        //��ʊO(Unity����񂩂�6m�ȏ����ɗ��ꂽ)�̃A�C�e����j��
        if (this.unitychan.transform.position.z > this.transform.position.z+6.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
