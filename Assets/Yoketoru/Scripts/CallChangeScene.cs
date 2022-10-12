using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallChangeScene : MonoBehaviour
{
    ToNextScene toNextScene;

    static float IgnoreKeySeconds => 0.5f;//�萔 IgnoreKeySeconds�@����� 0.5���A���Ă��āA����͂ł��Ȃ�
    float ignoreTime;

    // Start is called before the first frame update
    void Start()
    {
        toNextScene = GetComponent<ToNextScene>();
        ignoreTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //��莞�ԃL�[����𖳌���
        ignoreTime += Time.deltaTime;
        if (ignoreTime < IgnoreKeySeconds) return;
        

        //�G�f�B�b�g���v���W�F�N�g�Z�b�e�B���O���C���v�b�g�}�l�[�W���[��Axes����JAMP�̂Ƃ���Next�ɏ��������Ă���B������Next
        if (Input.GetButtonDown("Next"))
        {
            toNextScene.ChangeScene();
        }
    }
}
