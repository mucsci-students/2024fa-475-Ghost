using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{

    bool meleeActive, gunActive, grenadeActive;

    GameObject melee;
    GameObject gun;
    GameObject grenade;


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
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            Debug.Log("Scroll Down");
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
