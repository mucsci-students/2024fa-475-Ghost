using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class GrenadeThrower : MonoBehaviour
{

    public float throwForce = 40f;
    public GameObject grenadePrefab;
    public float coolDown = 6f;
    private float counter = 0f;

    [SerializeField]private Image Visible;

    private void Start()
    {
        counter = coolDown;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && counter > coolDown)
        {
            Visible.enabled = false;
            ThrowGrenade();
            counter = 0f;
           
        }
        if (counter > coolDown)
        {
            Visible.enabled = true;
            UIManager.Instance.UpdateAmmo(1);
        }
        else
        {
            UIManager.Instance.UpdateAmmo(0);
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

    public void Ammo()
    {
        Update();
    }
}
