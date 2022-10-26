using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Tooltip("����"), SerializeField]
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
       
        cameraDistance = Vector3.Distance(transform.position/*����*/,Camera.main.transform.position/*�J����*/);
     // Vector3.Distance(��ڂ̍��W,��ڂ̍��W);���������߂�


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //var ���[�J���ϐ��@�C���X�^���X�ł͎g����@���������邩�ɂ���Č^��ς��Ă����
        var mpos = Input.mousePosition; //�J�[�\�������킹��ƌ^�������邼�I����̓x�N�g���R       ���̎��̓J�[�\���̏ꏊ�̈ʒu����������
        //Debug.Log(mpos);

        
        
        mpos.z = cameraDistance;
        var wp = Camera.main.ScreenToWorldPoint(mpos);

        Vector3 to = wp - transform.position;//to = ���݈ꂩ��ړI�nwp�ւ̌����Ƒ傫���i�x�N�g���j



        //�܂�Ɉʒu����v���Ă��邱�Ƃ�����I�i�s����N���邱�Ƃ�����j��
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
            //rb.velocity = to; �ɂ���ƈ��������Ă�݂����ȓ����ɂȂ�
        }
        //transform.position = wp;//�A���`�p�^�[���@����܂������Ⴂ����炵��


    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.CompareTag("Enemy"))
        {/*
            SceneManager.LoadScene("Gameover",LoadSceneMode.Additive);
            //�啶���̂��͕̂ϐ���ێ�����炵���B
            Time.timeScale = 0;*/
            GameManager.ToGameover();
        }
    }


}
