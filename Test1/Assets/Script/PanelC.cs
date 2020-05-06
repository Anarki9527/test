using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class PanelC : MonoBehaviour {

    public Animator ani;
    void Start()
    {

    }

    public void OnBtnClick()
    {
        ani.SetTrigger("exit");
        Thread.Sleep(500);
        UIManager.Instance.ClossPanel("PanelC");
    }
}
