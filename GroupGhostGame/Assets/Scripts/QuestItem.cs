using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour
{
    public bool isItem1, isItem2, isItem3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isItem1)
            {
                other.GetComponent<Inventory>().hasObjItem1 = true;
                UIManager.Instance.UpdateKeys("red");
            }

            if (isItem2)
            {
                other.GetComponent<Inventory>().hasObjItem2 = true;
                UIManager.Instance.UpdateKeys("blue");
            }

            if (isItem3)
            {
                other.GetComponent<Inventory>().hasObjItem3 = true;
                UIManager.Instance.UpdateKeys("green");
            }
            Destroy(this.gameObject);
        }
    }
}
