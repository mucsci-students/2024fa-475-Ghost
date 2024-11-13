using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{

    bool meleeActive, gunActive, grenadeActive;

    public GameObject melee; // index 0
    public GameObject gun;
    public GameObject grenade; // index 2

    int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        melee.SetActive(true);
        gun.SetActive(false);
        grenade.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            Debug.Log("Scroll Up");
            index++;

            if (index > 2)
            {
                index = 0;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            Debug.Log("Scroll Down");
            index--;

            if (index < 0)
            {
                index = 2;
            }

        }


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            melee.SetActive(true);
            gun.SetActive(false);
            grenade.SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gun.SetActive(true);
            melee.SetActive(false);
            grenade.SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            grenade.SetActive(true);
            melee.SetActive(false);
            gun.SetActive(false);

        }
    }


}
