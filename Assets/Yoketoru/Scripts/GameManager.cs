#define DEBUG_KEY

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }


    [SerializeField]
    TextMeshProUGUI scoreText = default;
    /*[SerializeField]
    TextMeshProUGUI timeText = default;*/

    static int ScoreMax => 99999;//定数

    static int score;
    static float time;
    static float StartTime => 10;




    private void Awake()
    {
        Instance = this;
        ClesrScore();
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
            AddPoint(12345);
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
    public static void AddPoint(int add)
    {
        score += add;
        /*上限チェックその１　　手続き型の典型　分かりやすい
        
        if (score > ScoreMax)
        {
            score = ScoreMax;
        }
        */

        /*上限チェックその２　　手続き型の省略形　コンパクトに書ける
        //変数 = 条件式 ? 左の条件が成立していたら返してほしい値 : 不成立だったら返してほしい値 ;
        score = score > ScoreMax ? ScoreMax : score;
        */

        //上限チェックその３　　関数型で近代的
        //Min (最小値) Max(最大値)
        score = Mathf.Min(score + add,ScoreMax);




        if (Instance!=null)
        {
            Instance.UpdateScoreText();

        }
    }

    public static void ClesrScore()
    {
        score = 0;
        if (Instance!=null)
        {
            Instance.UpdateScoreText();
        }
    }

}
