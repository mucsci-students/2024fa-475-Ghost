using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SearchService;

public class ItemPickup : MonoBehaviour
{

    bool isHealth;
    bool isArmor;
    bool isAmmo;

    public int amount;

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
            if (isHealth)
            {
                other.getComponent<PlayerHealth>().HealHealth(amount, this.gameObject);
            }
            if (isArmor)
            {
                other.getComponent<PlayerHealth>().GetArmor(amount, this.gameObject);
            }
            if (isAmmo)
            {
                other.getComponentInChildren<Gun>().GetAmmo(amount, this.gameObject);
            }

            Destroy(gameObject);
            UnityEngine.Debug.Log("Picked up item");
        }
    }
}
