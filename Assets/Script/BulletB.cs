using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletB : MonoBehaviour
{
    [SerializeField] private Vector2 Dir;
    [SerializeField] private float speed = -0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Dir * speed);
    }
}
