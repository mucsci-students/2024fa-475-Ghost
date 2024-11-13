using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.InteropServices;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI health;
    public TextMeshProUGUI armor;
    public TextMeshProUGUI ammo;

    public Image healthImage;
    public Image weaponImage;

    //Add sprites later
    public Sprite health1; //Full health
    public Sprite health2; //Pretty Hurt
    public Sprite health3; //Really Hurt
    public Sprite health4; //Dead

    public GameObject redKey;
    public GameObject blueKey;
    public GameObject greenKey;

    public Sprite Gun;
    public Sprite Grenade;

    public GameObject GunHeld;
    public GameObject GrenadeHeld;

    private static UIManager _instance;
    public static UIManager Instance 
    { 
        get { return _instance;} 
    }

    private void Awake()
    {
        GrenadeHeld.SetActive(false);
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    //Update Methods
    public void UpdateHealth(int healthValue)
    {
        health.text = healthValue.ToString() + "%";
        UpdateHealthImage(healthValue);
    }

    public void UpdateArmor(int armorValue)
    {
        armor.text = armorValue.ToString() + "%";
    }

    public void UpdateAmmo(int ammoValue)
    {
        ammo.text = ammoValue.ToString();
    }

    public void UpdateHealthImage(int healthVal)
    {
        if (healthVal >= 66)
        {
            healthImage.sprite = health1; // Full Health
        }
        if(healthVal < 66 && healthVal >= 33)
        {
            healthImage.sprite = health2; // Pretty Hurt
        }
        if (healthVal < 33 && healthVal > 0)
        {
            healthImage.sprite = health3; // Badly Hurt
        }
        if (healthVal <= 0)
        {
            healthImage.sprite = health4; // Dead
        }
    }

    public void UpdateKeys(string color)
    {
        if (color == "red")
        {
            redKey.SetActive(true);
        }

        if (color == "blue")
        {
            blueKey.SetActive(true);
        }

        if (color == "green")
        {
            greenKey.SetActive(true);
        }
    }

    public void ClearKeys()
    {
        redKey.SetActive(false);
        blueKey.SetActive(false);
        greenKey.SetActive(false);
    }

    public void UpdateWeaponImage(int activeWeapon)
    {
        if(activeWeapon == 0)
        {
            GunHeld.SetActive(true);
            GrenadeHeld.SetActive(false);
            weaponImage.sprite = Gun;
        } else
        {
            GunHeld.SetActive(false);
            GrenadeHeld.SetActive(true);
            weaponImage.sprite = Grenade;
        }
    }

   


}
