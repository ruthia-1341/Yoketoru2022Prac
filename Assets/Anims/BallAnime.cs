using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAnime : MonoBehaviour
{
    Animator anim;


    // Start is called before the first frame update
    void Awake()//�������g�Ŋ������鏉������Awake�B���ׂĂ�Awake�̂��Ƃɏ������������ꍇ��Start�B
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //�{�^���������ꂽ��
        if (Input.GetButtonDown("Fire1"))
        {
            //�A�j���[�V��������
            anim.SetTrigger("Move");
        }
    }
}
