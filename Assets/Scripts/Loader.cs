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
        SceneManager.LoadSceneAsync(Scene.LoadingScene.ToString(), LoadSceneMode.Single);
    }
    public static void LoaderCallback()
    {
        SceneManager.LoadScene(targetScene.ToString());
    }
}

