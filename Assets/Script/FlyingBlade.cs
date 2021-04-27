using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBlade : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private GameObject flyingblade;
    [SerializeField] private float speed = 0.5f;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            _animator.SetTrigger("StartShout");
        else if (Input.GetKeyUp(KeyCode.I))
            _animator.SetTrigger("EndShout");
        if (Input.GetKeyDown(KeyCode.S))
        {
            var gameObject = Instantiate(flyingblade, transform.position, Quaternion.identity);
        }
    }
}