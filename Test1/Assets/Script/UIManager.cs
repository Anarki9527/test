using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    private string UI_GAMEPANEL_ROOT = "Prefab/Panel/";
    public GameObject m_CanvaRoot;
    public Dictionary<string, GameObject> m_PanelList = new Dictionary<string, GameObject>();

    private bool CheckCanvaRootIsNull()
    {
        if (m_CanvaRoot == null)
        {
            Debug.LogError("m_CanveRoot is Null");
            return true;
        }
        return false;
    }
    private bool IsPanelLive(string name)
    {
        return m_PanelList.ContainsKey(name);
    }
    public GameObject  ShowPanel (string name)
    {
        if (CheckCanvaRootIsNull())
                    return null; ;
        if(IsPanelLive(name))
        {
            Debug.LogErrorFormat("{(0)} is showing , if you want to show , pleast clost first", name);
            return null;
        }
        GameObject loadGo = Utility.AssetRelate.ResourcesLoadCheckNull<GameObject>(UI_GAMEPANEL_ROOT + name);
        if (loadGo == null)
        {
            return null;
        }
        GameObject panel = Utility.GameObjectRelate.InstantiateGameObject(m_CanvaRoot, loadGo);
        panel.name = name;

        m_PanelList.Add(name, panel);
        
        return panel;
    }
    public void TogglePanel(string name , bool isOn)
    {
        if (IsPanelLive(name))
        {
            if (m_PanelList[name] != null)
                m_PanelList[name].SetActive(isOn);
        }
        else
        {
            Debug.LogErrorFormat("TogglePanel[(0)] not found. ", name);
        }
    }
    public void ClosePanel(string name)
    {
        if (IsPanelLive(name) )
        {
            if (m_PanelList[name] != null)
                Object.Destroy(m_PanelList[name]);
            m_PanelList.Remove(name);
        }
        else
        {
            Debug.LogErrorFormat("TogglePanel[(0)] not found. ", name);
        }
    }
    public void CloseAllPanel()
    {
        foreach (KeyValuePair<string , GameObject > item in m_PanelList)
        {
            if (item.Value != null)
                Object.Destroy(item.Value);
        }
        m_PanelList.Clear();
    }
    public Vector2 GetCanveSize()
    {
        if (CheckCanvaRootIsNull())
            return Vector2.one * -1;

        RectTransform trans = m_CanvaRoot.transform as RectTransform; 

        return trans.sizeDelta;
    }

}


