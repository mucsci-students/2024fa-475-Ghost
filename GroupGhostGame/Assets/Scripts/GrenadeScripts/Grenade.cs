using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Grenade : MonoBehaviour
{

    public EnemyManager enemyManager;
    public LayerMask enemyLayers;
    public GameObject explosionEffect;

    private float delay = 3f;
    private float radius = 10f;
    private float force = 700f;
    private float upwardsModifier = 10f;
    private float maxDamage = 100f;

    float countdown;
    bool hasExploded = false;
    

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
        enemyManager = FindObjectOfType<EnemyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    void Explode()
    {
        Debug.Log("boom");
        //Shows the explosion effect
        Instantiate(explosionEffect, transform.position, transform.rotation);

        //Get nearby Objects
        Collider [] hitColliders = new Collider[10];

        int collidersHit = Physics.OverlapSphereNonAlloc(transform.position, radius, hitColliders);


        for (int i = 0; i < collidersHit; i++)
        {
            //Add force
            if (hitColliders[i].TryGetComponent(out Rigidbody rb))
            {
                rb.AddExplosionForce(force,transform.position, radius, upwardsModifier);
            }
            //Deal Damage
            if (hitColliders[i].TryGetComponent(out Enemy enemy))
            {
                enemy.TakeDamage(maxDamage - Vector3.Distance(transform.position, hitColliders[i].transform.position) * (maxDamage / radius));
            }

        }
        // Remove Grenade
        Destroy(gameObject);

    }
    
}
