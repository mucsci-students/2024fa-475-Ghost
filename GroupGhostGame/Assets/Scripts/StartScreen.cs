using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField]GameObject controls;

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void ShowControls()
    {
        controls.SetActive(true);
        gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
