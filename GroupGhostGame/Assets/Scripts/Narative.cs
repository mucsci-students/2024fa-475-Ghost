using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Narative : MonoBehaviour
{
    public GameObject player;
    public Canvas screen;
    public TextMeshProUGUI message;
    public TextMeshProUGUI button;
    // Start is called before the first frame update
    public void StartMessage()
    {
        screen.enabled = true;
        Time.timeScale = 0f;
        player.GetComponent<FirstPersonController>().enabled = false;
        player.GetComponent<WeaponInventory>().enabled = false;
        player.GetComponent<WeaponInventory>().gun.SetActive(false);
        player.GetComponent<WeaponInventory>().grenade.SetActive(false);
        //player.GetComponent<WeaponInventory>().manager.Clear();
        Cursor.lockState = CursorLockMode.None;
        message.text = "Pass the 4 Language Trials\r\nFirst: C";
        button.text = "Alright";
    }

    public void First()
    {
        screen.enabled = true;
        Time.timeScale = 0f;
        player.GetComponent<FirstPersonController>().enabled = false;
        player.GetComponent<WeaponInventory>().enabled = false;
        player.GetComponent<WeaponInventory>().gun.SetActive(false);
        player.GetComponent<WeaponInventory>().grenade.SetActive(false);
        //player.GetComponent<WeaponInventory>().manager.Clear();
        Cursor.lockState = CursorLockMode.None;
        message.text = "Good Job. Now to the next\r\nSecond: Java";
        button.text = "Let's Go";
    }
    public void Second()
    {
        screen.enabled = true;
        Time.timeScale = 0f;
        player.GetComponent<FirstPersonController>().enabled = false;
        player.GetComponent<WeaponInventory>().enabled = false;
        player.GetComponent<WeaponInventory>().gun.SetActive(false);
        player.GetComponent<WeaponInventory>().grenade.SetActive(false);
        //player.GetComponent<WeaponInventory>().manager.Clear();
        Cursor.lockState = CursorLockMode.None;
        message.text = "Java Done. Time for Snakes\r\nThird: Python";
        button.text = "Sssuper";
    }
    public void Third()
    {
        screen.enabled = true;
        Time.timeScale = 0f;
        player.GetComponent<FirstPersonController>().enabled = false;
        player.GetComponent<WeaponInventory>().enabled = false;
        player.GetComponent<WeaponInventory>().gun.SetActive(false);
        player.GetComponent<WeaponInventory>().grenade.SetActive(false);
        //player.GetComponent<WeaponInventory>().manager.Clear();
        Cursor.lockState = CursorLockMode.None;
        message.text = "Slithering No more. Time for pain\r\nLast: A S S E M B L Y";
        button.text = "Please No";
    }
    public void Fourth()
    {
        screen.enabled = true;
        Time.timeScale = 0f;
        player.GetComponent<FirstPersonController>().enabled = false;
        player.GetComponent<WeaponInventory>().enabled = false;
        player.GetComponent<WeaponInventory>().gun.SetActive(false);
        player.GetComponent<WeaponInventory>().grenade.SetActive(false);
        //player.GetComponent<WeaponInventory>().manager.Clear();
        Cursor.lockState = CursorLockMode.None;
        message.text = "You Passed the 4 Language Trials\r\nFind the Blue Locker";
        button.text = "Ominous";
    }

    public void Continue()
    {
        Time.timeScale = 1f;
        player.GetComponent<FirstPersonController>().enabled = true;
        player.GetComponent<WeaponInventory>().enabled = true;
        player.GetComponent<WeaponInventory>().Change();
        Cursor.lockState = CursorLockMode.Locked;
        screen.enabled = false;
    }
}
