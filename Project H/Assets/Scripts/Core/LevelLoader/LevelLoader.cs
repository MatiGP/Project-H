using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader
{
    private const string ADVENTURE_SCENE_NAME = "AdventureScene";
    private const string BATTLE_SCENE_NAME = "BattleScene";

    private static Dictionary<ESceneName, string> SCENE_NAMES = new Dictionary<ESceneName, string>()
    {
        { ESceneName.AdventureMap, ADVENTURE_SCENE_NAME },
        { ESceneName.BattleMap, BATTLE_SCENE_NAME }
    };

    public void LoadLevel(ESceneName sceneName)
    {
        if (SCENE_NAMES.ContainsKey(sceneName))
        {
            SceneManager.LoadScene(SCENE_NAMES[sceneName], LoadSceneMode.Additive);     
        }
        else
        {
            Debug.LogError("SCENE NAME DOES NOT EXIST. CHECK DICTIONARY + BUILD SETTINGS");
        }
    }
}
