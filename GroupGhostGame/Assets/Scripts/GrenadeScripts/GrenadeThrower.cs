using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class GrenadeThrower : MonoBehaviour
{

    public float throwForce = 40f;
    public GameObject grenadePrefab;
    public float coolDown = 1.5f;
    private float counter = 0f;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G) && counter >= coolDown)
        {
            ThrowGrenade();
            counter = 0f;
        }

        counter += Time.deltaTime;
    }

    void ThrowGrenade()
    {
        Vector3 spawnPos = transform.position + (transform.forward * 2);
        GameObject grenade = Instantiate(grenadePrefab, spawnPos, transform.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward  * throwForce, ForceMode.VelocityChange);
    }
}
