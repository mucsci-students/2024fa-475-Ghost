using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScreen : MonoBehaviour
{
    [SerializeField]GameObject prev;
    public void GoBack()
    {
        prev.SetActive(true);
        gameObject.SetActive(false);
    }
}
