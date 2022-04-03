using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private bool isFullscreen;

    private void Update()
    {
        Screen.fullScreen = isFullscreen;
    }
    public void GameScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

    public void SetFullscreen(bool isFullscreenP)
    {
        isFullscreen = isFullscreenP;
    }
}
