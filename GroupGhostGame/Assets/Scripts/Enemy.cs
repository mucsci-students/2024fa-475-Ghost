using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyManager enemyManager;
    private float enemyHealth = 4f;

    public GameObject gunHitEffect;
    public bool drops;
    private Drops myDrop;

    void Start()
    {
        enemyManager = FindObjectOfType<EnemyManager>();
        if(drops) myDrop = GetComponent<Drops>();
    }

    void Update()
    {
        if(enemyHealth <= 0)
        {
            enemyManager.RemoveEnemy(this);
            if (drops)
            {
                myDrop.Drop();
            }
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float damage)
    {
        Instantiate(gunHitEffect, transform.position, Quaternion.identity);
        enemyHealth -= damage;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(6);
        }
    }
}
