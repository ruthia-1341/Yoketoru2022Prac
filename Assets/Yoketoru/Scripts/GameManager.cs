#define DEBUG_KEY

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TinyAudio.PlaySE(TinyAudio.SE.Start);
    }

    // Update is called once per frame
    void Update()
    {
        //#if …のやつ、buildしたら作動しないだか何だか。跡形もなくなる。プリプロセッサプログラム？の真骨頂？らしい
         /* #if DEBUG_KEY

                if (Input.GetKeyDown(KeyCode.O))
                {
                    SceneManager.LoadScene("Gameover");
                }

                else if (Input.GetKeyDown(KeyCode.C))
                {
                    SceneManager.LoadScene("Clear");
                }

        #endif*/
     
        #if DEBUG_KEY
            if (Input.GetKeyDown(KeyCode.O))
            {
                SceneManager.LoadScene("Gameover", LoadSceneMode.Additive);//Additive＝追加
        }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
            }
        #endif
    }
}
