using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float range = 20f;
    public float verticalRange = 20f;
    public float gunShootRadius = 20f;

    public float bigDamage = 2f;
    public float smallDamage = 1f;

    public float fireRate = 1f;
    private float nextTimeToFire;

    public int maxAmmo;
    private int ammo;


    public LayerMask raycastLayerMask;
    public LayerMask enemyLayerMask;
    
    private BoxCollider gunTrigger;
    public EnemyManager enemyManager;

    // Start is called before the first frame update
    void Start()
    {
        gunTrigger = GetComponent<BoxCollider>();

        gunTrigger.size = new Vector3(1, verticalRange, range);
        gunTrigger.center = new Vector3(0, 0, range * 0.5f);

        UIManager.Instance.UpdateAmmo(ammo);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextTimeToFire && ammo > 0)
        {
            Fire();
        }
    }

    void Fire()
    {
        // simulate gun shoot radius
        Collider[] enemyCollider; 
        enemyCollider = Physics.OverlapSphere(transform.position, gunShootRadius, enemyLayerMask);

        // alert enemies
        foreach (Collider c in enemyCollider)
        {
            c.GetComponent<EnemyAware>().isAggro = true;
        }

        // damage enemies
        foreach (Enemy enemy in enemyManager.enemiesInTrigger)
        {
            Vector3 dir = enemy.transform.position - transform.position;

            RaycastHit hit;
            if (Physics.Raycast(transform.position, dir, out hit, range * 1.5f, raycastLayerMask, QueryTriggerInteraction.Ignore))
            {
                if (hit.transform == enemy.transform)
                {
                    float dist = Vector3.Distance(enemy.transform.position, transform.position);

                    //damage
                    if (dist > range * 0.5f)
                    {
                        enemy.TakeDamage(smallDamage);
                    }
                    else
                    {
                        enemy.TakeDamage(bigDamage);
                    }
                }
            }

        }

        //reset timer
        nextTimeToFire = Time.time + fireRate;

        //decrease ammo
        --ammo;

        UIManager.Instance.UpdateAmmo(ammo);
    }

    public void GetAmmo(int ammoGet, GameObject item)
    {
        if (ammo < maxAmmo)
        {
            ammo += ammoGet;
            //Destroy(item)
        }

        if (ammo > maxAmmo)
        {
            ammo = maxAmmo;
        }

        UIManager.Instance.UpdateAmmo(ammo);
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
