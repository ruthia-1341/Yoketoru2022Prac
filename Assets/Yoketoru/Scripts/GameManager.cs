#define DEBUG_KEY

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    static int score;
    static float time;
    static float StartTime => 10f;


    [SerializeField]
    TextMeshProUGUI scoreText = default;
    [SerializeField]
    TextMeshProUGUI timeText = default;



    private void Awake()
    {
        score = 0;
        time = StartTime;
/*
        clear = false;
        gameover = false;
        Item.ClearCount();*/

    }

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
        else if (Input.GetKey(KeyCode.P))
        {
            score += 1;
            UpdateScoreText();
        }
#endif
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = $"{score:00000}";
        }
    }

}
