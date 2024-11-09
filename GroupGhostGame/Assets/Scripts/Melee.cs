using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Melee : MonoBehaviour
{


    public Transform attackPoint;
    public LayerMask enemyLayers;
    public EnemyManager enemyManager;
     public float attackRange = 0.5f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Attack();
        } 
    }

    void Attack()
    {
        //Play attack animation  TODO

        //Detect enemies in range of attack
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

        //Damage enemies in range
        foreach (Enemy enemy in enemyManager.enemiesInTrigger)
            foreach (Collider e in hitEnemies)
            {
                enemy.TakeDamage(1f);
                Debug.Log("Enemy hit");
            }   
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
