using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//継承＝他のクラスの機能を受け継いで拡張
public class ToNextScene : MonoBehaviour
{
    [Tooltip("切り替えたいシーン名"),SerializeField]
    string nextScene = default;

    bool sceneChanged;

    public void ChangeScene()
    {
        if (sceneChanged) return;//sceneChangedがtrueなら　というif文　　trueならreturn(何もせず値を返す)という指示文

        sceneChanged = true;
        
        SceneManager.LoadScene(nextScene);
    }

}
