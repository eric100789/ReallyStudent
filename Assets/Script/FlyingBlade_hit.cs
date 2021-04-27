using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class FlyingBlade_hit : MonoBehaviour
{
    // Start is called before the first frame update
    private DateTime st_time;
    [SerializeField] private float speed;
    public Vector3 dir;


    void Start()
    {
        st_time = DateTime.Now;
    }


    void Update()
    {
        if (DateTime.Now.Subtract(st_time).Seconds >= 3)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(dir.normalized * speed);
    }
}

