using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{

    bool meleeActive, gunActive, grenadeActive;

    GameObject melee; // index 0
    GameObject gun;
    GameObject grenade; // index 2

    int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        
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


        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    melee.SetActive(true);
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    gun.SetActive(true);
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    grenade.SetActive(true);
        //}
    }


}
