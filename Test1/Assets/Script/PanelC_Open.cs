using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelC_Open : MonoBehaviour
{
    public void OnBtnShowClick()
    {
        UIManager.Instance.ShowPanel("PanelC");
        
    }
}
