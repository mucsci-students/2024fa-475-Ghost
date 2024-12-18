using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private GameObject door;

    public bool requiresKey;
    public bool reqRed, reqBlue, reqGreen, reqDegree;
    private bool open = false;

    public GameObject areaToSpawn;
    

    private void Start()
    {
        door = transform.GetChild(0).gameObject;
    }
    private void Update()
    {
        if (open)
        {
            door.SetActive(false);
            //Quaternion currentRot = door.transform.rotation;
            //Quaternion targetRot = Quaternion.Euler(0, (transform.rotation.y + 90f), 0);
            //door.transform.rotation = Quaternion.Slerp(currentRot, targetRot, 0.1f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (requiresKey)
            {
                // do logic

                if (reqRed && other.GetComponent<Inventory>().hasRed)
                {
                    //open door
                    open = true;
                    //spawn room
                    if(areaToSpawn != null) areaToSpawn.SetActive(true);
                }

                if (reqBlue && other.GetComponent<Inventory>().hasBlue)
                {
                    //open door
                    open = true;
                    //spawn room
                    if (areaToSpawn != null) areaToSpawn.SetActive(true);
                }

                if (reqGreen && other.GetComponent<Inventory>().hasGreen)
                {
                    //open door
                    open = true;
                    //spawn room
                    if (areaToSpawn != null) areaToSpawn.SetActive(true);
                }
                if (reqDegree && (other.GetComponent<Inventory>().hasUpLeft) && (other.GetComponent<Inventory>().hasUpRight) && (other.GetComponent<Inventory>().hasDownLeft) && (other.GetComponent<Inventory>().hasDownRight))
                {
                    //open door
                    open = true;
                    //spawn room
                    //areaToSpawn.SetActive(true);
                }
            }
            else
            {
                //open door
                //doorAnimator.SetTrigger("OpenDoor");
                open = true;
                //spawn room
                if (areaToSpawn != null) areaToSpawn.SetActive(true);
            }
        }
    }
}
