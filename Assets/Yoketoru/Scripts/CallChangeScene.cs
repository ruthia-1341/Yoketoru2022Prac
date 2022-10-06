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
        //エディット→プロジェクトセッティング→インプットマネージャー→AxesからJAMPのとこをNextに書き換えてある。そこのNext
        if (Input.GetButtonDown("Next"))
        {
            toNextScene.ChangeScene();
        }
    }
}
