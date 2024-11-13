using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegreePickup : MonoBehaviour
{
    public bool isDegreeOne, isDegreeTwo, isDegreeThree, isDegreeFour;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isDegreeOne)
            {
                other.GetComponent<Inventory>().hasUpLeft = true;
                UIManager.Instance.UpdateKeys("upLeft");
            }

            if (isDegreeTwo)
            {
                other.GetComponent<Inventory>().hasUpRight = true;
                UIManager.Instance.UpdateKeys("upRight");
            }

            if (isDegreeThree)
            {
                other.GetComponent<Inventory>().hasDownLeft = true;
                UIManager.Instance.UpdateKeys("lowLeft");
            }
           
            if (isDegreeFour)
            {
                other.GetComponent<Inventory>().hasDownRight = true;
                UIManager.Instance.UpdateKeys("lowRight");
            }
            Destroy(this.gameObject);
        }
    }

}
