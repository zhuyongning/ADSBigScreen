using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class G_Sc : MonoBehaviour {
    public InputField If_G_Ip;
    // 贺卡显示名字
    public Text Tx_G_Nm;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Up_Nm()
    {
        Tx_G_Nm.text = If_G_Ip.text;
    }

    // 截图
    public void Sn_Shot()
    {
        Texture2D Te = new Texture2D(395, 572, TextureFormat.RGB24, false);
        // 读取像素
        Te.ReadPixels(new Rect(120, 66, 395, 572), 0, 0, true);
        Te.Apply();
        // 将texture2d转换为png格式
        byte[] bytes = Te.EncodeToPNG();

        // 存储在资源管理器
        File.WriteAllBytes(Application.dataPath + "/ScreenShot.png", bytes);
    }
}
