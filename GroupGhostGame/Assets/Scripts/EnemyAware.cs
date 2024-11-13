using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAware : MonoBehaviour
{
    public float awarenessRadius = 8f;
    public bool isAggro;
    public Material agroMat;
    private Transform playerTransform;

    private void Start()
    {
        playerTransform = FindObjectOfType<FirstPersonController>().transform;
    }


    private void Update()
    {
        var dist = Vector3.Distance(transform.position, playerTransform.position);

        if (dist < awarenessRadius)
        {
            isAggro = true;
        }

        //if (isAggro)
        //{
        //    GetComponent<MeshRenderer>().material = agroMat;
        //}
    }
}
