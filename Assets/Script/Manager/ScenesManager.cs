using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Scene
{
    Battle,
    Main,
    Menu

}
public class ScenesManager : MonoBehaviour
{
    #region Singletone
    public static ScenesManager instance = null;
    public static ScenesManager Getinstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@ScenesManager");
            instance = go.AddComponent<ScenesManager>();

            DontDestroyOnLoad(go);
        }

        return instance;
    }
    #endregion

    #region Scene Control
    public Scene currentScene;
    public Scene prevScene;

    public void ChangeScene(Scene scene)
    {
        prevScene = currentScene;
        currentScene = scene;
        SceneManager.LoadScene(scene.ToString());
    }
    #endregion

}
