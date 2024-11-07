using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Can change colors if we want
    public bool hasRed, hasBlue, hasGreen;

    private void Start()
    {
        UIManager.Instance.ClearKeys();
    }
}
