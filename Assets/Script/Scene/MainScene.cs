using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    
    void Start()
    {
        ObjectManager.Getinstance().CreateCharacter();

        UIManager.Getinstance().SetEventSystem();
        UIManager.Getinstance().OpenUI("UIProfile");
        UIManager.Getinstance().OpenUI("UIActionMenu");
    }

   
  
}
