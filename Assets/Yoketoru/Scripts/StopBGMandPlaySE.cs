using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBGMandPlaySE : MonoBehaviour
{
    [Tooltip("�炵����SE"), SerializeField]
    TinyAudio.SE se = TinyAudio.SE.Miss;

    void Start()
    {
        TinyAudio.StopBGM(); 
        TinyAudio.PlaySE(se);
    }

}
