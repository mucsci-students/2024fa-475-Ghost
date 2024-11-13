using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Can change colors if we want
    public bool hasRed, hasBlue, hasGreen;

    public bool hasUpLeft, hasUpRight, hasDownLeft, hasDownRight;

    private void Start()
    {
        UIManager.Instance.ClearKeys();
    }
}
