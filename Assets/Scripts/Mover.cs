using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Mover : MonoBehaviour
{
    public Transform target;

    public int speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 1f, 0f, Space.Self);

        if (target != null)
        {
            transform.RotateAround(target.gameObject.transform.position, target.transform.up, speed * 1f);
        }
    }
}
