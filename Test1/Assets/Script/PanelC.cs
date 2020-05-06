using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class PanelC : MonoBehaviour {

    public Animator ani;
    // void Start()
    //{
    //     ani.SetTrigger("exit");
    //}

    public void OnBtnClick()
    {
        Thread.Sleep(500);
        UIManager.Instance.ClossPanel("PanelC");
    }
}
