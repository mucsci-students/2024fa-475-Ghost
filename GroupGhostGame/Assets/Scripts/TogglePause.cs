using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TogglePause : MonoBehaviour
{
    public GameObject player;
    public Canvas pauseMenu;
    // Track if the pause screen is active or not
    private bool ispaused = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        pauseMenu.enabled = ispaused;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ispaused = !ispaused;
        }

        if (ispaused)
        {
            Time.timeScale = 0f;
            player.SetActive(false);
        }
        if (!ispaused)
        {
            Time.timeScale = 1f;
            player.SetActive(true);
        }
    }

    public void ResumeButton()
    {
        ispaused = false;
    }
}
