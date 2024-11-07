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
        UIManager.Instance.UpdateHealth(health);
        UIManager.Instance.UpdateArmor(armor);
        //armor = maxArmor;
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
        UIManager.Instance.UpdateHealth(health);
        UIManager.Instance.UpdateArmor(armor);
    }

    //Could add the gameobject to the params and destroy in this method so that the items don't get destroyed when at max health or armor
    public void HealHealth(int healthGet, GameObject item)
    {
        if (health < maxHealth)
        {
            health += healthGet;
            //Destroy(item);
        }

        if(health > maxHealth)
        {
            health = maxHealth;
        }
        UIManager.Instance.UpdateHealth(health);
    }

    public void GetArmor(int armorGet, GameObject item)
    {
        if (armor < maxArmor)
        {
            armor += armorGet;
            //Destroy(item);
        }

        if(armor > maxArmor)
        {
            armor = maxArmor;
        }
        UIManager.Instance.UpdateArmor(armor);
    }
}
