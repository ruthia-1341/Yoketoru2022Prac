using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TinyAudio : MonoBehaviour
{
    public static TinyAudio Instance { get; private set; }


    public enum BGM
    {
        Gameover,
        Clear
    }

    [Tooltip("BGM����"), SerializeField]//���ӏ����B�R�����g�݂����Ȃ���
    AudioClip[] bgmList;



    /// <summary>
    /// seList�ɐݒ肷����ʉ��̎�ނ��ȉ��ɒ�`���܂��B
    /// </summary>



    public enum SE
    {
        Clear,
        Cursor,
        Item,
        Miss,
        Start,
    }
    [Tooltip("���ʉ���Audio Clip���ASE�̗񋓎q�Ɠ������ԂŐݒ肵�Ă��������B"), SerializeField]
    AudioClip[] seList;
    AudioSource audioSource;
    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    /// <summary>
    /// SE�Ŏw�肵�����ʉ����Đ����܂��B
    /// </summary>
    /// <param name="se">�炵�������ʉ�</param>
    public static void PlaySE(SE se)
    {
        Instance.audioSource.PlayOneShot(Instance.seList[(int)se]);
    }


    public static void StopBGM()
    {
        Instance.audioSource.Stop();
    }


    public static void PlayBGM(BGM bgm)
    {
        StopBGM();
        Instance.audioSource.clip = Instance.bgmList[(int)bgm];
        Instance.audioSource.Play();
    }


}

