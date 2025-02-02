using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField]
    float speedMin = 1f;

    [SerializeField]
    float speedMax = 5f;


    float speed;
    Rigidbody rb;

    // Start is called before the first frame update
    
        /*
        //----------------------ひな形（といってもいいくらい）の式---------------
        // speedに、speedMin〜speedMaxの速度を乱数で求める
        speed = Random.Range(speedMin,speedMax);
        var th = Random.Range(0, 360);//１〜３５９

        var dir = new Vector3(Mathf.Cos(th * Mathf.Deg2Rad), Mathf.Sin(th * Mathf.Deg2Rad), 0);
        
        rd = GetComponent<Rigidbody>();
        rd.velocity = speed * dir;
        //------------------------------------------------------------------------
        */

        // speedに、speedMin〜speedMaxの速度を乱数で求める
        void Awake()
        {
            speed = Random.Range(speedMin, speedMax);
            rb = GetComponent<Rigidbody>();
            SetRandomVelocity();
        }


        //Th

        void SetRandomVelocity()
        {
            var th = Random.Range(0, 360);
            var dir = new Vector3(Mathf.Cos(th * Mathf.Deg2Rad), Mathf.Sin(th * Mathf.Deg2Rad), 0);
            rb.velocity = dir * speed;
        }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mathf.Approximately(rb.velocity.magnitude,0f))
        {
            SetRandomVelocity();
        }
        else
        {
            rb.velocity = speed * rb.velocity.normalized;
        }
    }
    /*
    void FixedUpdate()
    {
        // if (rb.velocity.magnitude == 0f) 浮動小数点ではこれはNG
        if (Mathf.Approximately(rb.velocity.magnitude, 0f))
        {
            SetRandomVelocity();
        }
        rb.velocity = rb.velocity.normalized * speed;
    }
*/
}
