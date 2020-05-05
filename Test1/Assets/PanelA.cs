using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelA : MonoBehaviour
{
        public void OnBtnClick()
    {
        UIManager.Instance.ClossPanel("PanelA");
    }
}
