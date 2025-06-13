using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    private static Scene targetScene;

    public enum Scene
    {
        MainMenuScene,
        LoadingScene,
        OptionsScene,
        GameScene
    }
    public static void Load(Scene targetSceneName)
    {
        Loader.targetScene = targetSceneName;
        SceneManager.LoadScene(Scene.LoadingScene.ToString());      
    }
    public static void LoaderCallback()
    {
        SceneManager.LoadScene(targetScene.ToString());
    }
}

