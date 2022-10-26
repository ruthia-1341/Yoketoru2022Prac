using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Tooltip("速さ"), SerializeField]
    float speed = 20;
    
    float cameraDistance ;

    Rigidbody rb ;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Start is called before the first frame update
    void Start()
    {
       
        cameraDistance = Vector3.Distance(transform.position/*自分*/,Camera.main.transform.position/*カメラ*/);
     // Vector3.Distance(一つ目の座標,二つ目の座標);距離を求める


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //var ローカル変数　インスタンスでは使えん　何を代入するかによって型を変えてくれる
        var mpos = Input.mousePosition; //カーソルを合わせると型が見えるぞ！これはベクトル３       この式はカーソルの場所の位置が分かるやつ
        //Debug.Log(mpos);

        
        
        mpos.z = cameraDistance;
        var wp = Camera.main.ScreenToWorldPoint(mpos);

        Vector3 to = wp - transform.position;//to = 現在一から目的地wpへの向きと大きさ（ベクトル）



        //まれに位置が一致していることがある！（不具合が起きることがある）↓
        if (to.magnitude<0.01f)
        {
            rb.velocity = Vector3.zero;
        }
        else 
        {
            float step = speed * Time.deltaTime;
            float dist = Mathf.Min(to.magnitude, step);
            float v = dist / Time.deltaTime;
            rb.velocity = v * to.normalized;

             //rb.velocity = to / Time.deltaTime;
            //rb.velocity = to; にすると引っ張られてるみたいな動きになる
        }
        //transform.position = wp;//アンチパターン　あんまりやっちゃいけんらしい


    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.CompareTag("Enemy"))
        {/*
            SceneManager.LoadScene("Gameover",LoadSceneMode.Additive);
            //大文字のものは変数を保持するらしい。
            Time.timeScale = 0;*/
            GameManager.ToGameover();
        }
    }


}
