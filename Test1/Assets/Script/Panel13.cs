using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel13 : MonoBehaviour
{
    public void OnBtnClickOpen()
    {
        UIManager.Instance.ShowPanel("Panel13");
    }
    public void OnBtnClickClose()
    {
        UIManager.Instance.ClosePanel("Panel13");
    }
}
