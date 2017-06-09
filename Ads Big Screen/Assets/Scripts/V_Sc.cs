using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class V_Sc : MonoBehaviour {

    // 播放广告视频
    public RawImage Rim_V_BG;
    // 存储视频
    public MovieTexture Vo;
    // 存储声音
    public AudioClip VoAu;


    // Use this for initialization
    void Start () {
        St_Vo();
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void St_Vo()
    {
        Vo.loop = true;
        Vo.Play();
        // 将纹理设置为视频
        Rim_V_BG.texture = Vo;

        VoAu = Vo.audioClip;
        gameObject.GetComponent<AudioSource>().clip = VoAu;
        gameObject.GetComponent<AudioSource>().Play();
    }

    public void Stop_Vo()
    {
        Vo.Stop();
        gameObject.GetComponent<AudioSource>().Stop();
    }

}
