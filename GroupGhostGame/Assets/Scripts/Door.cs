using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator doorAnimator;

    public bool requiresKey;
    public bool reqRed, reqBlue, reqGreen;

    public GameObject areaToSpawn;

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
                    doorAnimator.SetTrigger("OpenDoor");
                    //spawn room
                    areaToSpawn.SetActive(true);
                }

                if (reqBlue && other.GetComponent<Inventory>().hasBlue)
                {
                    //open door
                    doorAnimator.SetTrigger("OpenDoor");
                    //spawn room
                    areaToSpawn.SetActive(true);
                }

                if (reqGreen && other.GetComponent<Inventory>().hasGreen)
                {
                    //open door
                    doorAnimator.SetTrigger("OpenDoor");
                    //spawn room
                    areaToSpawn.SetActive(true);
                }

            }
            else
            {
                //open door
                doorAnimator.SetTrigger("OpenDoor");
                //spawn room
                areaToSpawn.SetActive(true);
            }

            

        }
    }
}
