using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float range = 20f;
    public float verticalRange = 20f;
    public float fireRate;

    public float bigDamage = 2f;
    public float smallDamage = 1f;

    private float nextTimeToFire;
    private BoxCollider gunTrigger;


    public LayerMask raycastLayerMask;
    public EnemyManager enemyManager;

    // Start is called before the first frame update
    void Start()
    {
        gunTrigger = GetComponent<BoxCollider>();

        gunTrigger.size = new Vector3(1, verticalRange, range);
        gunTrigger.center = new Vector3(0, 0, range * 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextTimeToFire)
        {
            Fire();
        }
    }

    void Fire()
    {
        // damage enemies
        foreach (Enemy enemy in enemyManager.enemiesInTrigger)
        {
            Vector3 dir = enemy.transform.position - transform.position;

            RaycastHit hit;
            if (Physics.Raycast(transform.position, dir, out hit, range * 1.5f, raycastLayerMask))
            {
                Debug.Log(hit.transform.position);
                if (hit.transform == enemy.transform)
                {
                    float dist = Vector3.Distance(enemy.transform.position, transform.position);

                    if (dist > range * 0.5f)
                    {
                        enemy.TakeDamage(smallDamage);
                    }
                    else
                    {
                        enemy.TakeDamage(bigDamage);
                    }

                    //damage
                    

                    Debug.DrawRay(transform.position, dir, Color.green);
                    Debug.Break();
                }
            }

        }

        //reset timer
        nextTimeToFire = Time.time + fireRate;
    }

    private void OnTriggerEnter(Collider other)
    {
        //add enemy
        Enemy enemy = other.GetComponent<Enemy>();
        
        if (enemy)
        {
            enemyManager.AddEnemy(enemy);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //remove enemy
        Enemy enemy = other.GetComponent<Enemy>();

        if (enemy)
        {
            enemyManager.RemoveEnemy(enemy);
        }
    }
}
