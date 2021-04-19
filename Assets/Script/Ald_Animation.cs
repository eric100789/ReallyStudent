using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ald_Animation : MonoBehaviour
{
    [SerializeField] private Animator SwordsMan;
    [SerializeField] private SpriteRenderer SwordsManSpriteRenderer;
    [SerializeField] private Animator RedFlashMagic;

    

    // Update is called once per frame

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.E) )
        {
            SwordsMan.SetBool("IsWalk", true);
            SwordsManSpriteRenderer.flipX = false;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.E))
        {
            SwordsMan.SetBool("IsWalk", false);
        }

        if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.E))
        {
            SwordsMan.SetBool("IsWalk", true);
            SwordsManSpriteRenderer.flipX = true;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.E))
        {
            SwordsMan.SetBool("IsWalk", false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwordsMan.SetBool("IsAttack", true);
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            SwordsMan.SetBool("IsAttack", false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            SwordsMan.SetBool("IsSwing", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            SwordsMan.SetBool("IsSwing", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SwordsMan.SetFloat("IsShout", 5.0f);
            RedFlashMagic.SetBool("Magic_Power", true);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            SwordsMan.SetFloat("IsShout", 0f);
            RedFlashMagic.SetBool("Magic_Power", false);
        }
    }
}
