using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAnime : MonoBehaviour
{
    Animator anim;


    // Start is called before the first frame update
    void Awake()//自分自身で完結する初期化はAwake。すべてのAwakeのあとに初期化したい場合はStart。
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //ボタンが押されたら
        if (Input.GetButtonDown("Fire1"))
        {
            //アニメーション制御
            anim.SetTrigger("Move");
        }
    }
}
