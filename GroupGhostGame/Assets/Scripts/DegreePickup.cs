using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DegreePickup : MonoBehaviour
{
    public Narative narative;
    public Inventory playerInv;
    public bool isDegreeOne, isDegreeTwo, isDegreeThree, isDegreeFour;

    // Start is called before the first frame update
    void Start()
    {
        narative = FindObjectOfType<Narative>();
        playerInv = FindObjectOfType<Inventory>();
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
                narative.Second();
            }

            if (isDegreeTwo)
            {
                other.GetComponent<Inventory>().hasUpRight = true;
                narative.First();
            }

            if (isDegreeThree)
            {
                other.GetComponent<Inventory>().hasDownLeft = true;
                narative.Fourth();
            }
           
            if (isDegreeFour)
            {
                other.GetComponent<Inventory>().hasDownRight = true;
                narative.Third();
            }
            playerInv.UpdateDegree();
            Destroy(this.gameObject);
        }
    }

}
