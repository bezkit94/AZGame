﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadingController : MonoBehaviour
{
    public bool IsLoading { get; private set; }
    public float Progress { get; private set; }
    public System.Action<GameScene> onLoadingComplete = delegate { };
    public System.Action<GameScene> onLoadingBegin = delegate { };

    public static SceneLoadingController Instance { get; private set; }

    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        IsLoading = false;
        Progress = 0f;
    }

    public void LoadMainScene(GameScene scene)
    {
        StartCoroutine(SceneLoad(GameScene.Menu));
    }

    public void LoadScene(GameScene scene, bool withUnload)
    {
        StartCoroutine(SceneLoad(scene, withUnload));
    }

    IEnumerator SceneLoad(GameScene scene, bool withUnload = false)
    {
        if (withUnload)
        {
            Scene sceneToUnload = SceneManager.GetActiveScene();
            AsyncOperation unloadScene = SceneManager.UnloadSceneAsync(sceneToUnload.name);
            while (unloadScene != null && !unloadScene.isDone)
            {
                yield return new WaitForEndOfFrame();
            }
        }

        string sceneToLoad = GetSceneName(scene);

        AsyncOperation loading = SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Additive);

        while (loading != null && !loading.isDone)
        {
            Progress = loading.progress;

            yield return new WaitForSeconds(0.2f);
        }

        Scene loadedScene = SceneManager.GetSceneByName(sceneToLoad);
        SceneManager.SetActiveScene(loadedScene);
    }

    private string GetSceneName(GameScene scene)
    {
        switch (scene)
        {
            case GameScene.Menu:
                return "002_Menu";
            case GameScene.Adventure:
                return "003_Adventure";
            case GameScene.Tavern:
                return "004_Tavern";
            default:
                return string.Empty;
        }
    }
}