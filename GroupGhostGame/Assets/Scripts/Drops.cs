using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Drops : MonoBehaviour
{
    public GameObject drop;
    public void Drop()
    {
        Instantiate(drop, new Vector3(transform.position.x, 1f, transform.position.z), transform.rotation);
    }
}
