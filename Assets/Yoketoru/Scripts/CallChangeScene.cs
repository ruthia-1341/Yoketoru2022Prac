using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallChangeScene : MonoBehaviour
{
    ToNextScene toNextScene;

    static float IgnoreKeySeconds => 0.5f;//定数 IgnoreKeySeconds　からは 0.5が帰ってきて、代入はできない
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
        //一定時間キー操作を無効化
        ignoreTime += Time.deltaTime;
        if (ignoreTime < IgnoreKeySeconds) return;
        

        //エディット→プロジェクトセッティング→インプットマネージャー→AxesからJAMPのとこをNextに書き換えてある。そこのNext
        if (Input.GetButtonDown("Next"))
        {
            toNextScene.ChangeScene();
        }
    }
}
