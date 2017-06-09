using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // 奇幻旅程button
    public void Bt_M_V_Q()
    {
        gameObject.GetComponent<V_Sc>().St_Vo();
    }

    // 拍照button
    public void Bt_M_A_P()
    {
        gameObject.GetComponent<V_Sc>().Stop_Vo();
    }

    // 输入名字确认button
    public void Bt_GIp_St()
    {
        gameObject.GetComponent<G_Sc>().Up_Nm();
        gameObject.GetComponent<G_Sc>().Sn_Shot();
    }
}
