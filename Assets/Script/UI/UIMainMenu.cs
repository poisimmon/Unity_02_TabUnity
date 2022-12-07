using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIMainMenu : MonoBehaviour
{
    Button btnStart;

    void Start()
    {
        btnStart = GetComponentInChildren<Button>();
        btnStart.onClick.AddListener(OnclickStart);
    }

    
    void OnclickStart()
    {
        ScenesManager.Getinstance().ChangeScene(Scene.Main);
    }
    
        
    
}
