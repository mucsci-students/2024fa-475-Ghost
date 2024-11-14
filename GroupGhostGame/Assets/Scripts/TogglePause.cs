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
        ispaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ispaused = !ispaused;

            if (ispaused)
            {
                Pause();
            }
            if (!ispaused)
            {
                ResumeButton();
            }
        }
    }

    private void Pause()
    {
        ispaused = true;
        Time.timeScale = 0f;
        player.GetComponent<FirstPersonController>().enabled = false;
        player.GetComponent<WeaponInventory>().gun.SetActive(false);
        player.GetComponent<WeaponInventory>().grenade.SetActive(false);
        //player.GetComponent<WeaponInventory>().manager.Clear();
        Cursor.lockState = CursorLockMode.None;
        pauseMenu.enabled = ispaused;
    }

    public void ResumeButton()
    {
        ispaused = false;
        Time.timeScale = 1f;
        player.GetComponent<FirstPersonController>().enabled = true;
        player.GetComponent<WeaponInventory>().Change();
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenu.enabled = ispaused;
    }
}
