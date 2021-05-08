using UnityEngine;

public class Kate_Animation : MonoBehaviour
{
    // -------variable---------
    [SerializeField] private Animator Killer;
    [SerializeField] private Transform KillerPlace ;
    [SerializeField] private SpriteRenderer KillerRenderer;
    [SerializeField] private SpriteRenderer PowerfulMagicRenderer;
    [SerializeField] private Transform PowerfulMagicTran;
    [SerializeField] private Animator RedFlashMagic;
    [SerializeField] private Animator PowerfulMagic;
    [SerializeField] private Animator KillerGhost;
    [SerializeField] private SpriteRenderer KillerGhostRenderer;
    // -------variable---------


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.R))
        {
            Killer.SetBool("IsWalk", true);
            KillerRenderer.flipX = false;
            KillerGhostRenderer.flipX = false;
            PowerfulMagicRenderer.flipX = false;
            PowerfulMagicTran.transform.position = new Vector3(KillerPlace.transform.position.x - 1.5f, KillerPlace.transform.position.y, 9.7f);
            KillerGhost.transform.position = new Vector3(KillerPlace.transform.position.x - 0.58f, KillerPlace.transform.position.y, 9.7f);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.R))
        {
            Killer.SetBool("IsWalk", false);
        }

        if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.R))
        {
            Killer.SetBool("IsWalk", true);
            KillerRenderer.flipX = true;
            KillerGhostRenderer.flipX = true;
            PowerfulMagicRenderer.flipX = true;
            PowerfulMagicTran.transform.position = new Vector3(KillerPlace.transform.position.x+ 1.5f, KillerPlace.transform.position.y , 9.7f);
            KillerGhost.transform.position = new Vector3(KillerPlace.transform.position.x + 0.58f, KillerPlace.transform.position.y, 9.7f);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.R))
        {
            Killer.SetBool("IsWalk", false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Killer.SetBool("IsAttack1", true);
            KillerGhost.SetBool("IsAttack1", true);
            PowerfulMagic.SetTrigger("IsHit");
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            Killer.SetBool("IsAttack1", false);
            KillerGhost.SetBool("IsAttack1", false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Killer.SetBool("IsAttack2", true);
            KillerGhost.SetBool("IsAttack2", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            Killer.SetBool("IsAttack2", false);
            KillerGhost.SetBool("IsAttack2", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Killer.SetBool("IsAttack3", true);
            KillerGhost.SetBool("IsAttack3", true);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            Killer.SetBool("IsAttack3", false);
            KillerGhost.SetBool("IsAttack3", false);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Killer.SetBool("IsLaugh", true);
            RedFlashMagic.SetBool("Magic_Power", true);
            PowerfulMagic.SetBool("IsPowerful", true);
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            Killer.SetBool("IsLaugh", false);
            RedFlashMagic.SetBool("Magic_Power", false);
        }

        if (Input.GetKey(KeyCode.C))
        {
            Killer.SetBool("IsBlock", true);
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            Killer.SetBool("IsBlock", false);
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            Killer.SetBool("IsSpell", true);
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Killer.SetBool("IsSpell", false);
        }
    }
}

