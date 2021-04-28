using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBlade : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private GameObject BaseBullet;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            var gameObject = Instantiate(BaseBullet, transform.position, Quaternion.identity);
        }
    }
}