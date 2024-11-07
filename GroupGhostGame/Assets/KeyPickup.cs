using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public bool isRedKey, isBlueKey, isGreenKey;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isRedKey)
            {
                other.GetComponent<Inventory>().hasRed = true;
                UIManager.Instance.UpdateKeys("red");
            }

            if (isBlueKey)
            {
                other.GetComponent<Inventory>().hasBlue = true;
                UIManager.Instance.UpdateKeys("blue");
            }

            if (isGreenKey)
            {
                other.GetComponent<Inventory>().hasGreen = true;
                UIManager.Instance.UpdateKeys("green");
            }
            Destroy(this.gameObject);
        }
    }
}
