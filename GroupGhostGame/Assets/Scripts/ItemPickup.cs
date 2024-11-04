using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SearchService;

public class ItemPickup : MonoBehaviour
{
    CapsuleCollider playerColider;

    // Start is called before the first frame update
    void Start()
    {
        playerColider = FindObjectOfType<FirstPersonController>().GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerColider.tag))
        {
            Destroy(this.gameObject);
            UnityEngine.Debug.Log("Picked up item");
        }
    }
}
