using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //Can change colors if we want
    public bool hasRed, hasBlue, hasGreen;

    public bool hasUpLeft, hasUpRight, hasDownLeft, hasDownRight;

    public Image degreeImage;
    public TextMeshProUGUI degreeCount;
    private int count = 0;

    private void Start()
    {
        UIManager.Instance.ClearKeys();
    }

    public void UpdateDegree()
    {
        count++;
        degreeCount.text = count.ToString() + "/4";
        if(count == 4)
        {
            degreeImage.enabled = true;
        }

    }
}
