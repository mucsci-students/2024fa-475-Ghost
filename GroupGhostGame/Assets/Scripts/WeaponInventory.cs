using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{

    bool meleeActive, gunActive, grenadeActive;

    //public GameObject melee; // index 0
    public GameObject gun;
    public GameObject grenade; // index 2
    private GameObject[] inventory = new GameObject[2];

    int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        //melee.SetActive(true);
        gun.SetActive(false);
        grenade.SetActive(false);
        //inventory[0] = melee;
        inventory[0] = gun;
        inventory[1] = grenade;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            Debug.Log("Scroll Up");
            index--;

            if (index < 0)
            {
                index = 1;
            }
            Change();
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            Debug.Log("Scroll Down");
            index++;

            if (index > 1)
            {
                index = 0;
            }
            Change();
        }


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            index = 0;
            Change();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            index = 1;
            Change();
        }
        //if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    index = 2;
        //    Change();
        //}
    }

    private void Change()
    {
        foreach (GameObject item in inventory)
        {
            item.SetActive(false);
        }
        inventory[index].SetActive(true);
    }
}
