using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[CreateAssetMenu( fileName = "SceneManager")]
public class SceneSwitcher : MonoBehaviour
{
    private Stack<int> loadedLevels;

    [System.NonSerialized]
    private bool initialized;

    private void Init()
    {
        loadedLevels = new Stack<int>();
        initialized = true;
        Debug.LogError("swiggity swoogity");
    }

    public UnityEngine.SceneManagement.Scene GetActiveScene()
    {
        return UnityEngine.SceneManagement.SceneManager.GetActiveScene();
    }

    private void LoadScene(int buildIndex)
    {
        if (!initialized) Init();
        loadedLevels.Push(GetActiveScene().buildIndex);
        UnityEngine.SceneManagement.SceneManager.LoadScene(buildIndex);
    }

    public void LoadScene(string sceneName)
    {
        if (!initialized) Init();
        loadedLevels.Push(GetActiveScene().buildIndex);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void LoadPreviousScene()
    {
        if (!initialized)
        {
            Debug.LogError("You haven't used the LoadScene functions of the scriptable object. Use them instead of the LoadScene functions of Unity's SceneManager.");
        }
        if (loadedLevels.Count > 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(loadedLevels.Pop());
        }
        else
        {
            Debug.LogError("No previous scene loaded");
            // If you want, you can call `Application.Quit()` instead
        }
    }

    /*
    public void GotoPolarBearExhibit()
    {
        sceneHistory.Add(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("PolarBearExhibit");
    }

    public void GotoMainMenu()
    {
        sceneHistory.Add(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("MainMenu");
    }

    public void GotoSettings()
    {
        sceneHistory.Add(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Settings");
    }

    public void GotoCustomize()
    {
        sceneHistory.Add(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Customize");
    }

    public void GotoMap()
    {
        sceneHistory.Add(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("MainMap");
    }

    public void GoToBreathe()
    {
        sceneHistory.Add(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("BreathScreen");
    }

    public void OhFuckGoBack()
    {
        sceneHistory.RemoveAt(sceneHistory.Count - 1);
        UnityEngine.SceneManagement.SceneManager.LoadScene(loadedLevels.Pop());
    }
    */
}
