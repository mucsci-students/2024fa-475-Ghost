using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Can change colors if we want
    public bool hasRed, hasBlue, hasGreen;

    public bool hasObjItem1, hasObjItem2, hasObjItem3;

    private void Start()
    {
        UIManager.Instance.ClearKeys();
    }
}
