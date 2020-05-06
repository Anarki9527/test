using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelC_Open : MonoBehaviour
{
    public Animator ani;
    void Start()
    {
        ani.SetTrigger("enter");
    }

    public void OnBtnShowClick()
    {
        UIManager.Instance.ShowPanel("PanelC");
        
    }
}
