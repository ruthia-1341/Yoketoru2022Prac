using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var ���[�J���ϐ��@�C���X�^���X�ł͎g����@���������邩�ɂ���Č^��ς��Ă����
        var mpos = Input.mousePosition; //�J�[�\�������킹��ƌ^�������邼�I����̓x�N�g���R
        Debug.Log(mpos);
    }
}
