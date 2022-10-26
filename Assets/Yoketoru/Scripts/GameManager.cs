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

    static int ScoreMax => 99999;//�萔

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
        //#if �c�̂�Abuild������쓮���Ȃ������������B�Ռ`���Ȃ��Ȃ�B�v���v���Z�b�T�v���O�����H�̐^�����H�炵��
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
                SceneManager.LoadScene("Gameover", LoadSceneMode.Additive);//Additive���ǉ�
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
        /*����`�F�b�N���̂P�@�@�葱���^�̓T�^�@������₷��
        
        if (score > ScoreMax)
        {
            score = ScoreMax;
        }
        */

        /*����`�F�b�N���̂Q�@�@�葱���^�̏ȗ��`�@�R���p�N�g�ɏ�����
        //�ϐ� = ������ ? ���̏������������Ă�����Ԃ��Ăق����l : �s������������Ԃ��Ăق����l ;
        score = score > ScoreMax ? ScoreMax : score;
        */

        //����`�F�b�N���̂R�@�@�֐��^�ŋߑ�I
        //Min (�ŏ��l) Max(�ő�l)
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
