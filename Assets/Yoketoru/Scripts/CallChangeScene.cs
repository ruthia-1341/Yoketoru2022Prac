using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallChangeScene : MonoBehaviour
{
    ToNextScene toNextScene;

    // Start is called before the first frame update
    void Start()
    {
        toNextScene = GetComponent<ToNextScene>();
    }

    // Update is called once per frame
    void Update()
    {
        //�G�f�B�b�g���v���W�F�N�g�Z�b�e�B���O���C���v�b�g�}�l�[�W���[��Axes����JAMP�̂Ƃ���Next�ɏ��������Ă���B������Next
        if (Input.GetButtonDown("Next"))
        {
            toNextScene.ChangeScene();
        }
    }
}
