using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
    #region Singletone
    public static UIManager instance = null;

    public static UIManager Getinstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@UIManager");
            instance = go.AddComponent<UIManager>();

            DontDestroyOnLoad(go);
        }

        return instance;
    }
    #endregion

    #region UI Control
   
    public void SetEventSystem()
    {
        if (FindObjectOfType<EventSystem>() == false)
        {
            GameObject go = new GameObject("@EventSystem");
            go.AddComponent<EventSystem>();
            go.AddComponent<StandaloneInputModule>();
        }
    }
    
    Dictionary<string, GameObject> uiList = new Dictionary<string, GameObject>();

    public void OpenUI(string uiName)
    {
        if (uiList.ContainsKey(uiName) == false)
        {

            Object uiObj = Resources.Load($"UI/{uiName}");
            GameObject go = (GameObject)Instantiate(uiObj);

            uiList.Add(uiName, go);
        }
        else
        {
            uiList[uiName].SetActive(true);
        }
    }

    public void CloseUI(string uiName)
    {
        if (uiList.ContainsKey(uiName))
        {
            uiList[uiName].SetActive(false);
        }          
    }
    #endregion
}
