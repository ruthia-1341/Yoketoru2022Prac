using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var ローカル変数　インスタンスでは使えん　何を代入するかによって型を変えてくれる
        var mpos = Input.mousePosition; //カーソルを合わせると型が見えるぞ！これはベクトル３
        Debug.Log(mpos);
    }
}
