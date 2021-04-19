using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ald_Walk : MonoBehaviour
{

    [SerializeField] private float Speed = 0.06f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.left * Speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.right * Speed);
        }

    }
}
