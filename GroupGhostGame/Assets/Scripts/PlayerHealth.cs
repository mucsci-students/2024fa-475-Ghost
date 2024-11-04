using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int health;

    public int maxArmor = 100;
    private int armor;
    
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        armor = maxArmor;
    }

    // Update is called once per frame
    void Update()
    {
        // temp function
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            TakeDamage(10);
            UnityEngine.Debug.Log("Player Damaged");
        }
    }

    public void TakeDamage(int damage)
    {
        //if player has armor
        if (armor > 0)
        {
            if (armor >= damage)
            {
                armor -= damage;
            }
            //if damage is higher than armor
            else if (armor < damage)
            {
                int remaning = damage - armor;
                armor = 0;
                health -= remaning;
            }
        }
        else 
        { 
            health -= damage; 
        }

        if (health <= 0)
        {
            //player dies

            UnityEngine.Debug.Log("Died :(");

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.buildIndex);
        }
    }

    public void HealHealth(int healthGet)
    {
        health += healthGet;
    }

    public void GetArmor(int armorGet)
    {
        armor += armorGet;
    }
}
